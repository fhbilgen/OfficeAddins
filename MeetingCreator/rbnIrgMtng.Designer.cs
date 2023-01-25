namespace MeetingCreator
{
    partial class rbnIrgMtng : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public rbnIrgMtng()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbIrgMtng = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnAppointment = this.Factory.CreateRibbonButton();
            this.btnMeeting = this.Factory.CreateRibbonButton();
            this.btnTeamsMeeting = this.Factory.CreateRibbonButton();
            this.tbIrgMtng.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbIrgMtng
            // 
            this.tbIrgMtng.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tbIrgMtng.Groups.Add(this.group1);
            this.tbIrgMtng.Label = "Irregular Meetings";
            this.tbIrgMtng.Name = "tbIrgMtng";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnAppointment);
            this.group1.Items.Add(this.btnMeeting);
            this.group1.Items.Add(this.btnTeamsMeeting);
            this.group1.Label = "Irregulars";
            this.group1.Name = "group1";
            // 
            // btnAppointment
            // 
            this.btnAppointment.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAppointment.Label = "New Appointment";
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.ShowImage = true;
            // 
            // btnMeeting
            // 
            this.btnMeeting.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnMeeting.Label = "New Meeting";
            this.btnMeeting.Name = "btnMeeting";
            this.btnMeeting.ShowImage = true;
            this.btnMeeting.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnMeeting_Click);
            // 
            // btnTeamsMeeting
            // 
            this.btnTeamsMeeting.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnTeamsMeeting.Label = "New Teams Meeting";
            this.btnTeamsMeeting.Name = "btnTeamsMeeting";
            this.btnTeamsMeeting.ShowImage = true;
            // 
            // rbnIrgMtng
            // 
            this.Name = "rbnIrgMtng";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tbIrgMtng);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tbIrgMtng.ResumeLayout(false);
            this.tbIrgMtng.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tbIrgMtng;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAppointment;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnMeeting;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnTeamsMeeting;
    }

    partial class ThisRibbonCollection
    {
        internal rbnIrgMtng Ribbon1
        {
            get { return this.GetRibbon<rbnIrgMtng>(); }
        }
    }
}
