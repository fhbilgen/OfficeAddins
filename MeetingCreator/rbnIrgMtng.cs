using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools.Outlook;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
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
            frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            frm.Show();            
        }
    }
}
