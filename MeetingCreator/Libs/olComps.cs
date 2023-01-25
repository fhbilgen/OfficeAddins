using Outlook = Microsoft.Office.Interop.Outlook;

namespace MeetingCreator.Libs
{
    internal class olComps
    {        
        public static Outlook.NameSpace olSession { get; set; }
    }
}
