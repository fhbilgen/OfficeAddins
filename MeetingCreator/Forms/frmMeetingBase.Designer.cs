using System.Windows.Forms;

namespace MeetingCreator.Forms
{
    partial class frmMeetingBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnParticipants = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbRequired = new System.Windows.Forms.TextBox();
            this.tbOptional = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.rctbContent = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblOptional = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpImportance = new System.Windows.Forms.GroupBox();
            this.rbImpNormal = new System.Windows.Forms.RadioButton();
            this.rbImpLow = new System.Windows.Forms.RadioButton();
            this.rbImpHigh = new System.Windows.Forms.RadioButton();
            this.lblImportance = new System.Windows.Forms.Label();
            this.btnAddDate = new System.Windows.Forms.Button();
            this.lvDates = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblReminder = new System.Windows.Forms.Label();
            this.cmbReminder = new System.Windows.Forms.ComboBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.cmbStart = new System.Windows.Forms.ComboBox();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.checkedLBResponseOptions = new System.Windows.Forms.CheckedListBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblResOptions = new System.Windows.Forms.Label();
            this.cmbEnd = new System.Windows.Forms.ComboBox();
            this.lblTZ = new System.Windows.Forms.Label();
            this.cmbTZ = new System.Windows.Forms.ComboBox();
            this.lblDates = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPrivate = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ttNewMeeting = new System.Windows.Forms.ToolTip(this.components);
            this.lblRequired = new System.Windows.Forms.Label();
            this.ctxMenu.SuspendLayout();
            this.grpImportance.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnParticipants
            // 
            this.btnParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParticipants.Location = new System.Drawing.Point(664, 48);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Size = new System.Drawing.Size(88, 42);
            this.btnParticipants.TabIndex = 1;
            this.btnParticipants.Text = "Participants";
            this.ttNewMeeting.SetToolTip(this.btnParticipants, "Click to open the Address dialog box");
            this.btnParticipants.UseVisualStyleBackColor = true;
            this.btnParticipants.Click += new System.EventHandler(this.BtnParticipants_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(36, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 16);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // tbRequired
            // 
            this.tbRequired.Location = new System.Drawing.Point(96, 49);
            this.tbRequired.Multiline = true;
            this.tbRequired.Name = "tbRequired";
            this.tbRequired.Size = new System.Drawing.Size(560, 40);
            this.tbRequired.TabIndex = 2;
            this.ttNewMeeting.SetToolTip(this.tbRequired, "Required participants of the meeting");
            // 
            // tbOptional
            // 
            this.tbOptional.Location = new System.Drawing.Point(96, 103);
            this.tbOptional.Multiline = true;
            this.tbOptional.Name = "tbOptional";
            this.tbOptional.Size = new System.Drawing.Size(560, 40);
            this.tbOptional.TabIndex = 3;
            this.ttNewMeeting.SetToolTip(this.tbOptional, "Optional participants of the meeting");
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(96, 15);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(656, 20);
            this.tbTitle.TabIndex = 0;
            this.ttNewMeeting.SetToolTip(this.tbTitle, "Please enter the subject of the meeting");
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(16, 408);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(103, 16);
            this.lblContent.TabIndex = 20;
            this.lblContent.Text = "Meeting Content";
            // 
            // rctbContent
            // 
            this.rctbContent.Location = new System.Drawing.Point(16, 440);
            this.rctbContent.Name = "rctbContent";
            this.rctbContent.Size = new System.Drawing.Size(624, 192);
            this.rctbContent.TabIndex = 13;
            this.rctbContent.Text = "";
            this.ttNewMeeting.SetToolTip(this.rctbContent, "Enter the meeting content, agenda, etc. here");
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(664, 496);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(88, 48);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Send";
            this.ttNewMeeting.SetToolTip(this.btnSend, "Send the meeting requests for each date ");
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // lblOptional
            // 
            this.lblOptional.AutoSize = true;
            this.lblOptional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptional.Location = new System.Drawing.Point(24, 115);
            this.lblOptional.Name = "lblOptional";
            this.lblOptional.Size = new System.Drawing.Size(57, 16);
            this.lblOptional.TabIndex = 22;
            this.lblOptional.Text = "Optional";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(664, 584);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 48);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.ttNewMeeting.SetToolTip(this.btnClose, "Close this window");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // grpImportance
            // 
            this.grpImportance.Controls.Add(this.rbImpNormal);
            this.grpImportance.Controls.Add(this.rbImpLow);
            this.grpImportance.Controls.Add(this.rbImpHigh);
            this.grpImportance.Location = new System.Drawing.Point(96, 256);
            this.grpImportance.Name = "grpImportance";
            this.grpImportance.Size = new System.Drawing.Size(208, 40);
            this.grpImportance.TabIndex = 8;
            this.grpImportance.TabStop = false;
            // 
            // rbImpNormal
            // 
            this.rbImpNormal.AutoSize = true;
            this.rbImpNormal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbImpNormal.Location = new System.Drawing.Point(136, 14);
            this.rbImpNormal.Name = "rbImpNormal";
            this.rbImpNormal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbImpNormal.Size = new System.Drawing.Size(57, 17);
            this.rbImpNormal.TabIndex = 2;
            this.rbImpNormal.TabStop = true;
            this.rbImpNormal.Text = "Normal";
            this.ttNewMeeting.SetToolTip(this.rbImpNormal, "Normal priority meeting");
            this.rbImpNormal.UseVisualStyleBackColor = true;
            // 
            // rbImpLow
            // 
            this.rbImpLow.AutoSize = true;
            this.rbImpLow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbImpLow.Location = new System.Drawing.Point(77, 14);
            this.rbImpLow.Name = "rbImpLow";
            this.rbImpLow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbImpLow.Size = new System.Drawing.Size(44, 17);
            this.rbImpLow.TabIndex = 1;
            this.rbImpLow.TabStop = true;
            this.rbImpLow.Text = "Low";
            this.ttNewMeeting.SetToolTip(this.rbImpLow, "Low priority meeting");
            this.rbImpLow.UseVisualStyleBackColor = true;
            // 
            // rbImpHigh
            // 
            this.rbImpHigh.AutoSize = true;
            this.rbImpHigh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbImpHigh.Location = new System.Drawing.Point(16, 14);
            this.rbImpHigh.Name = "rbImpHigh";
            this.rbImpHigh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbImpHigh.Size = new System.Drawing.Size(46, 17);
            this.rbImpHigh.TabIndex = 0;
            this.rbImpHigh.TabStop = true;
            this.rbImpHigh.Text = "High";
            this.ttNewMeeting.SetToolTip(this.rbImpHigh, "High priority meeting");
            this.rbImpHigh.UseVisualStyleBackColor = true;
            // 
            // lblImportance
            // 
            this.lblImportance.AutoSize = true;
            this.lblImportance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportance.Location = new System.Drawing.Point(15, 268);
            this.lblImportance.Name = "lblImportance";
            this.lblImportance.Size = new System.Drawing.Size(74, 16);
            this.lblImportance.TabIndex = 3;
            this.lblImportance.Text = "Importance";
            // 
            // btnAddDate
            // 
            this.btnAddDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDate.Location = new System.Drawing.Point(692, 152);
            this.btnAddDate.Name = "btnAddDate";
            this.btnAddDate.Size = new System.Drawing.Size(60, 42);
            this.btnAddDate.TabIndex = 12;
            this.btnAddDate.Text = "Add";
            this.ttNewMeeting.SetToolTip(this.btnAddDate, "Add the meeting date");
            this.btnAddDate.UseVisualStyleBackColor = true;
            this.btnAddDate.Click += new System.EventHandler(this.BtnAddDate_Click);
            // 
            // lvDates
            // 
            this.lvDates.AutoArrange = false;
            this.lvDates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvDates.ContextMenuStrip = this.ctxMenu;
            this.lvDates.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvDates.HideSelection = false;
            this.lvDates.Location = new System.Drawing.Point(424, 200);
            this.lvDates.Name = "lvDates";
            this.lvDates.Size = new System.Drawing.Size(328, 224);
            this.lvDates.TabIndex = 6;
            this.lvDates.TabStop = false;
            this.lvDates.UseCompatibleStateImageBehavior = false;
            this.lvDates.View = System.Windows.Forms.View.Details;
            this.lvDates.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LvDates_KeyUp);
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReminder.Location = new System.Drawing.Point(19, 229);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(66, 16);
            this.lblReminder.TabIndex = 5;
            this.lblReminder.Text = "Reminder";
            // 
            // cmbReminder
            // 
            this.cmbReminder.FormattingEnabled = true;
            this.cmbReminder.Location = new System.Drawing.Point(96, 227);
            this.cmbReminder.Name = "cmbReminder";
            this.cmbReminder.Size = new System.Drawing.Size(87, 21);
            this.cmbReminder.TabIndex = 7;
            this.ttNewMeeting.SetToolTip(this.cmbReminder, "When should be a reminder triggered ");
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(18, 159);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(68, 16);
            this.lblStartTime.TabIndex = 0;
            this.lblStartTime.Text = "Start Time";
            // 
            // cmbStart
            // 
            this.cmbStart.FormattingEnabled = true;
            this.cmbStart.Location = new System.Drawing.Point(96, 157);
            this.cmbStart.Name = "cmbStart";
            this.cmbStart.Size = new System.Drawing.Size(86, 21);
            this.cmbStart.TabIndex = 4;
            this.ttNewMeeting.SetToolTip(this.cmbStart, "Select the start time of the meeting");
            this.cmbStart.SelectedIndexChanged += new System.EventHandler(this.cmbStart_SelectedIndexChanged);
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(424, 173);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(182, 20);
            this.dtPicker.TabIndex = 11;
            this.ttNewMeeting.SetToolTip(this.dtPicker, "Pick a meeting date");
            // 
            // checkedLBResponseOptions
            // 
            this.checkedLBResponseOptions.FormattingEnabled = true;
            this.checkedLBResponseOptions.Location = new System.Drawing.Point(96, 308);
            this.checkedLBResponseOptions.Name = "checkedLBResponseOptions";
            this.checkedLBResponseOptions.Size = new System.Drawing.Size(161, 64);
            this.checkedLBResponseOptions.TabIndex = 10;
            this.ttNewMeeting.SetToolTip(this.checkedLBResponseOptions, "Response options for the recipients");
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.Location = new System.Drawing.Point(216, 159);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(65, 16);
            this.lblEndTime.TabIndex = 2;
            this.lblEndTime.Text = "End Time";
            // 
            // lblResOptions
            // 
            this.lblResOptions.AutoEllipsis = true;
            this.lblResOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResOptions.Location = new System.Drawing.Point(16, 312);
            this.lblResOptions.Name = "lblResOptions";
            this.lblResOptions.Size = new System.Drawing.Size(72, 32);
            this.lblResOptions.TabIndex = 9;
            this.lblResOptions.Text = "Response Options";
            this.lblResOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbEnd
            // 
            this.cmbEnd.FormattingEnabled = true;
            this.cmbEnd.Location = new System.Drawing.Point(304, 157);
            this.cmbEnd.Name = "cmbEnd";
            this.cmbEnd.Size = new System.Drawing.Size(88, 21);
            this.cmbEnd.TabIndex = 5;
            this.ttNewMeeting.SetToolTip(this.cmbEnd, "Select the end time of the meeting");
            // 
            // lblTZ
            // 
            this.lblTZ.AutoSize = true;
            this.lblTZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTZ.Location = new System.Drawing.Point(19, 194);
            this.lblTZ.Name = "lblTZ";
            this.lblTZ.Size = new System.Drawing.Size(67, 16);
            this.lblTZ.TabIndex = 10;
            this.lblTZ.Text = "Timezone";
            // 
            // cmbTZ
            // 
            this.cmbTZ.FormattingEnabled = true;
            this.cmbTZ.Location = new System.Drawing.Point(96, 192);
            this.cmbTZ.Name = "cmbTZ";
            this.cmbTZ.Size = new System.Drawing.Size(296, 21);
            this.cmbTZ.TabIndex = 6;
            this.ttNewMeeting.SetToolTip(this.cmbTZ, "The timezone for the meeting hours");
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDates.Location = new System.Drawing.Point(424, 152);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(87, 15);
            this.lblDates.TabIndex = 24;
            this.lblDates.Text = "Meeting Dates";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "before meeting";
            // 
            // cbPrivate
            // 
            this.cbPrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrivate.Location = new System.Drawing.Point(320, 262);
            this.cbPrivate.Name = "cbPrivate";
            this.cbPrivate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbPrivate.Size = new System.Drawing.Size(72, 28);
            this.cbPrivate.TabIndex = 9;
            this.cbPrivate.Text = "Private";
            this.cbPrivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttNewMeeting.SetToolTip(this.cbPrivate, "Should this be a private meeting?");
            this.cbPrivate.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Location = new System.Drawing.Point(16, 648);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(624, 23);
            this.lblStatus.TabIndex = 27;
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.Location = new System.Drawing.Point(21, 61);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(63, 16);
            this.lblRequired.TabIndex = 28;
            this.lblRequired.Text = "Required";
            // 
            // frmMeetingBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(776, 695);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblImportance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDates);
            this.Controls.Add(this.cmbTZ);
            this.Controls.Add(this.lblTZ);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblOptional);
            this.Controls.Add(this.cmbEnd);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblResOptions);
            this.Controls.Add(this.rctbContent);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.checkedLBResponseOptions);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.cmbStart);
            this.Controls.Add(this.tbOptional);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.tbRequired);
            this.Controls.Add(this.cmbReminder);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.btnParticipants);
            this.Controls.Add(this.lvDates);
            this.Controls.Add(this.btnAddDate);
            this.Controls.Add(this.grpImportance);
            this.Controls.Add(this.cbPrivate);
            this.Name = "frmMeetingBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Meeting";
            this.ctxMenu.ResumeLayout(false);
            this.grpImportance.ResumeLayout(false);
            this.grpImportance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParticipants;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbOptional;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.RichTextBox rctbContent;
        private System.Windows.Forms.Button btnSend;        
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label lblOptional;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbRequired;
        private System.Windows.Forms.GroupBox grpImportance;
        private System.Windows.Forms.Label lblImportance;
        private System.Windows.Forms.RadioButton rbImpNormal;
        private System.Windows.Forms.RadioButton rbImpLow;
        private System.Windows.Forms.RadioButton rbImpHigh;
        private System.Windows.Forms.Button btnAddDate;
        private System.Windows.Forms.ListView lvDates;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.ComboBox cmbReminder;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.ComboBox cmbStart;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.CheckedListBox checkedLBResponseOptions;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblResOptions;
        private System.Windows.Forms.ComboBox cmbEnd;
        private System.Windows.Forms.Label lblTZ;
        private System.Windows.Forms.ComboBox cmbTZ;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbPrivate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolTip ttNewMeeting;
        private ColumnHeader columnHeader1;
        private Label lblRequired;
    }
}