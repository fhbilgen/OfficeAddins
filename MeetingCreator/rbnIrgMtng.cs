using Microsoft.Office.Tools.Ribbon;

namespace MeetingCreator
{
    public partial class rbnIrgMtng
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnMeeting_Click(object sender, RibbonControlEventArgs e)
        {
            Forms.frmMeetingBase frm = new Forms.frmMeetingBase();
            frm.Show();          
        }
    }
}
