using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using MeetingCreator.Libs;
using Microsoft.Office.Interop.Outlook;
using System.Runtime.InteropServices;

namespace MeetingCreator.Forms
{
    public partial class frmMeetingBase : Form
    {
                
        private Outlook.NameSpace _ns;
        private List<string> Requireds = new List<string>();
        private List<string> Optionals = new List<string>();        
        private bool ToggleStartEnd = false;
                        
        public frmMeetingBase()
        {
            InitializeComponent();            
            _ns = olComps.olSession;            
            
            FillComponentValues();
            SetComponentValuesToDefault();
        }

        private void FillComponentValues()
        {
            cmbStart.DataSource = MeetingParameters.MeetingTimes.ToArray();
            cmbEnd.DataSource = MeetingParameters.MeetingTimes.ToArray();
            cmbReminder.DataSource = MeetingParameters.Reminders.ToArray();
            foreach (var str in MeetingParameters.ResponseOptions)
                checkedLBResponseOptions.Items.Add(str, CheckState.Checked);

            cmbTZ.DataSource = new BindingSource(MeetingParameters.TimeZones, null);
            cmbTZ.DisplayMember = "Value";
            cmbTZ.ValueMember = "Key";

            // Set the hidden column's width to something large enough
            lvDates.Columns[0].Width = (int)(this.lvDates.Width * 0.99);
            
        }

        private void SetComponentValuesToDefault()
        {
            DateTime dt = DateTime.Now;
            // Set the start and end time values
            MeetingParameters.GetTimes(dt, out int startIdx, out int endIdx);
            cmbStart.SelectedIndex = startIdx;
            cmbEnd.SelectedIndex = endIdx;

            // Set the default reminder interval value to 15 minutes
            cmbReminder.SelectedIndex = 4;

            // The default importance is none
            rbImpNormal.Checked = true;

            // The default privacy is false            
            cbPrivate.Checked = false;

            //checkedLBResponseOptions
            // The default value is that all of the options are checked which is done so in FillComponentValues

            // Set the Timezone to the system time zone
            System.TimeZone localZone = System.TimeZone.CurrentTimeZone;
            cmbTZ.SelectedValue = localZone.StandardName;

            // There are no meetings 
            lblStatus.Text = MeetingParameters.NoMeetings;

            ToggleStartEnd = true;
        }

        private void ClearRecipients()
        {
            Requireds.Clear();
            Optionals.Clear();
        }

        private void DeleteDates()
        {
            ListView.SelectedListViewItemCollection col = lvDates.SelectedItems;
            foreach (ListViewItem lvi in col)
                lvDates.Items.Remove(lvi);

            lblStatus.Text = CalculateMeetingDatesStatus();
        }

        private string CalculateMeetingDatesStatus()
        {
            DateTime min = MeetingParameters.MinDate, max = MeetingParameters.MaxDate, cur;

            foreach (ListViewItem lvi in lvDates.Items)
            {
                cur = DateTime.Parse(ExtractMeetingDate(lvi.Text));

                if (DateTime.Compare(cur, min) < 0)
                    min = cur;

                if (DateTime.Compare(cur, max) > 0)
                    max = cur;
            }

            if (lvDates.Items.Count == 0)
                return MeetingParameters.NoMeetings;

            var str = lvDates.Items.Count < 2 ? $"is {lvDates.Items.Count} meeting" : $"are {lvDates.Items.Count} meetings";
            return $"There {str} between {min.ToLongDateString()} and {max.ToLongDateString()}";
        }
        
        private string DecorateMeetingDateAndTime(string date, string startHour, string endHour)
        {
            return $"{date}{MeetingParameters.MeetingHours[0]}{startHour}{MeetingParameters.MeetingHours[1]}{endHour}";
        }

        private string ExtractMeetingDate(string MeetingDateAndTime)
        {
            int i = MeetingDateAndTime.IndexOf(MeetingParameters.MeetingHours[0]);
            return MeetingDateAndTime.Substring(0, i);
        }

        private MeetingTimes ExtractMeetingTimes(string MeetingDateAndTime)
        {
            MeetingTimes mt = new MeetingTimes();
            var d = ExtractMeetingDate(MeetingDateAndTime);
            var t1 = MeetingDateAndTime.IndexOf(MeetingParameters.MeetingHours[0], 0) + MeetingParameters.MeetingHours[0].Length;
            var t2 = MeetingDateAndTime.IndexOf(MeetingParameters.MeetingHours[1], 0);

            var d1 = d + " " + MeetingDateAndTime.Substring(t1, t2 - t1);
            var d2 = d + " " + MeetingDateAndTime.Substring(t2 + MeetingParameters.MeetingHours[1].Length);
            
            mt.StartTime = DateTime.Parse(d1);
            mt.EndTime = DateTime.Parse(d2);
            
            return mt;
        }

        private bool AreMeetingTimesValid()
        {
            if (cmbStart.SelectedIndex >= cmbEnd.SelectedIndex)
            {
                MessageBox.Show(this, "Meeting start time should be earlier than the end time", "New Meeting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
                return true;
        }

        private List<MeetingTimes> PopulateMeetingDateandTimes()
        {
            List<MeetingTimes> dtMeetings = new List<MeetingTimes>();

            foreach (ListViewItem liv in lvDates.Items)
                dtMeetings.Add(ExtractMeetingTimes(liv.Text));
            
            return dtMeetings;
        }

        private Outlook.AppointmentItem BuildMeeting(DateTime start, DateTime end)
        {
            Outlook.Recipient r = null;
            Outlook.AppointmentItem appt = null;

            try
            {
                appt = _ns.Application.CreateItem(Outlook.OlItemType.olAppointmentItem) as Outlook.AppointmentItem;
                appt.Subject = tbTitle.Text;
                appt.MeetingStatus = Outlook.OlMeetingStatus.olMeeting;

                // Populate the recipients

                foreach (var str in Requireds)
                {
                    r = appt.Recipients.Add(str);
                    r.Type = (int)Outlook.OlMeetingRecipientType.olRequired;
                }

                foreach (var str in Optionals)
                {
                    r = appt.Recipients.Add(str);
                    r.Type = (int)Outlook.OlMeetingRecipientType.olOptional;
                }

                appt.Recipients.ResolveAll();


                // Start and end date times and the time zone
                appt.Start = start;
                appt.End = end;

                if (cmbReminder.Text != MeetingParameters.Reminders[0])
                {
                    appt.ReminderSet = true;
                    appt.ReminderMinutesBeforeStart = MeetingParameters.ReminderMinutes[cmbReminder.SelectedIndex];
                }
                else
                    appt.ReminderSet = false;

                // Application.TimeZones is a 1-based collection !!!
                appt.StartTimeZone = _ns.Application.TimeZones[cmbTZ.SelectedIndex+1];
                appt.EndTimeZone = _ns.Application.TimeZones[cmbTZ.SelectedIndex+1];

                // Setting meeting importance to either Normal, Low or High
                appt.Importance = OlImportance.olImportanceNormal;
                if (!rbImpNormal.Checked)
                {
                    appt.Importance = rbImpHigh.Checked ? OlImportance.olImportanceHigh : OlImportance.olImportanceLow;
                }
                                
                appt.Sensitivity = cbPrivate.Checked ? OlSensitivity.olPrivate : OlSensitivity.olNormal;


                // Allow the recipients to suggest new dates or not
                appt.ResponseRequested = checkedLBResponseOptions.GetItemChecked(0);

                Outlook.PropertyAccessor pa = appt.PropertyAccessor;

                if (checkedLBResponseOptions.GetItemChecked(1))
                    pa.SetProperty(MeetingParameters.allowProposeNewTime, false);
                else
                    pa.SetProperty(MeetingParameters.allowProposeNewTime, true);


                // This is not working !!!
                // Allow the recipients to forward the meeting or not
                if (checkedLBResponseOptions.GetItemChecked(2))
                    pa.SetProperty(MeetingParameters.allowForward, false);
                else
                    pa.SetProperty(MeetingParameters.allowForward, true);


                // Getting the meeting content in Rich Text Format and setting it to the meeting body
                // Need to add formatting capability in the future

                byte[] byteContent = System.Text.Encoding.UTF8.GetBytes(rctbContent.Rtf);
                appt.RTFBody = byteContent;

            }
            finally
            {
                if (r!=null)
                    Marshal.ReleaseComObject(r);
            }            

            return appt;
        }
        
        
        private void BtnParticipants_Click(object sender, EventArgs e)
        {
            Outlook.SelectNamesDialog snd = null;
            Outlook.Recipient r = null;

            try
            {
                ClearRecipients();

                foreach (var addr in tbRequired.Text.Split( new char[] { ';'}, StringSplitOptions.RemoveEmptyEntries )) 
                    Requireds.Add(addr);

                foreach (var addr in tbOptional.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
                    Optionals.Add(addr);

                snd = _ns.GetSelectNamesDialog();
                snd.AllowMultipleSelection = true;
                snd.NumberOfRecipientSelectors = Outlook.OlRecipientSelectors.olShowToCc;
                snd.ToLabel = "Required";
                snd.CcLabel = "Optional";

                foreach (var str in Requireds)
                {
                    r = snd.Recipients.Add(str);
                    r.Type = (int)Outlook.OlMeetingRecipientType.olRequired;
                }

                foreach (var str in Optionals)
                {
                    r = snd.Recipients.Add(str);
                    r.Type = (int)Outlook.OlMeetingRecipientType.olOptional;
                }


                if (!snd.Recipients.ResolveAll())
                    MessageBox.Show("Not all recipients are resolved");
                
                snd.Display();
                
                // If the form is not brought to front then the active window in the Z-order becomes the Outlook App itself
                this.BringToFront();

                if (snd.Recipients.Count == 0)
                    return;

                ClearRecipients();

                foreach (Outlook.Recipient recipient in snd.Recipients)
                {
                    switch (recipient.Type)
                    {
                        case (int)Outlook.OlMeetingRecipientType.olRequired:
                            Requireds.Add(recipient.Name);
                            break;
                        case (int)Outlook.OlMeetingRecipientType.olOptional:
                            Optionals.Add(recipient.Name);
                            break;
                        default:
                            break;
                    }
                }

                tbRequired.Text = string.Join(";", Requireds);
                tbOptional.Text = string.Join(";", Optionals);
            }
            finally
            {
                if (r != null)
                    Marshal.ReleaseComObject(r);
                if (snd != null)
                    Marshal.ReleaseComObject(snd);
            }        
            
        }
               
        private void BtnAddDate_Click(object sender, EventArgs e)
        {
            if (!AreMeetingTimesValid())
            {
                return;
            }

            ListViewItem lvi = new ListViewItem(DecorateMeetingDateAndTime(dtPicker.Value.ToLongDateString(), cmbStart.Text, cmbEnd.Text));

            // Don't allow duplicate dates.
            // It is not the best solution but the maximum dates should be less than 50 and this is a UI app therefore it should be ok

            if (lvDates.FindItemWithText(lvi.Text) == null)
                lvDates.Items.Add(lvi);
            else
                MessageBox.Show(this, "A meeting on the same date and time exists already", "New Meeting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            lblStatus.Text = CalculateMeetingDatesStatus();
        }
        
        private void LvDates_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteDates();
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            Outlook.AppointmentItem ai = null;
            List<MeetingTimes> meetingDateTimes = PopulateMeetingDateandTimes();            
            
            try
            {
               
                foreach(MeetingTimes mt in meetingDateTimes)
                {                    
                    ai = BuildMeeting(mt.StartTime, mt.EndTime);
                    ai.Send();
                    Marshal.ReleaseComObject(ai);
                }

                var i = meetingDateTimes.Count;
                string str = i < 2 ? $"{i} meeting request has been sent" : $"{i} meeting requests have been sent";

                MessageBox.Show( this, str, "Meeting requests send status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Meeting requests send status", MessageBoxButtons.OK, MessageBoxIcon.Error);                  
            }

        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDates();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ToggleStartEnd)
                return;
            
            cmbEnd.SelectedIndex = (cmbStart.SelectedIndex + 1) % MeetingParameters.MeetingTimes.Length;            
        }

    }
}
