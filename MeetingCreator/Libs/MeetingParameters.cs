using System;
using System.Collections.Generic;
using System.Globalization;

namespace MeetingCreator.Libs
{
    internal static class MeetingParameters
    {
        public static readonly string NoMeetings = "There are no meetings";
        public static readonly string[] MeetingTimes = { "12:00 AM", "12:30 AM", "01:00 AM", "01:30 AM", "02:00 AM", "02:30 AM", "03:00 AM", "03:30 AM", "04:00 AM", "04:30 AM", "05:00 AM", "05:30 AM", "06:00 AM", "06:30 AM",
                                                  "07:00 AM", "07:30 AM", "08:00 AM", "08:30 AM", "09:00 AM", "09:30 AM", "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM", "12:00 PM", "12:30 PM", "01:00 PM", "01:30 PM",
                                                  "02:00 PM", "02:30 PM", "03:00 PM", "03:30 PM", "04:00 PM", "04:30 PM", "05:00 PM", "05:30 PM", "06:00 PM", "06:30 PM", "07:00 PM", "07:30 PM", "08:00 PM", "08:30 PM",
                                                  "09:00 PM", "09:30 PM", "10:00 PM", "10:30 PM", "11:00 PM", "11:30 PM" };
                
        public static readonly string[] Reminders = { "None", "0 minutes", "5 minutes", "10 minutes", "15 minutes", "30 minutes", 
                                                      "1 hour", "2 hours", "3 hours", "4 hours", "5 hours", "6 hours", "7 hours", "8 hours", "9 hours", "10 hours", "11 hours",
                                                      "0.5 days", "18 hours", "1 day", "2 days", "3 days", "4 days", "1 week", "2 weeks"};

        public static readonly int[] ReminderMinutes = { 0, 0, 5, 10, 15, 30, 
                                                         60, 120, 180, 240, 300, 360, 420, 480, 540, 600, 660, 
                                                        720, 1080, 1440, 2880, 4320, 5760, 10080, 20160 };


        public static readonly string[] MeetingHours = { " between ", " and "};

        public static readonly string[] ResponseOptions = { "Request Response", "Allow New Time Proposals", "Allow Forwarding" };

        public static readonly string allowProposeNewTime = "http://schemas.microsoft.com/mapi/id/{00062002-0000-0000-C000-000000000046}/825A000B";
        public static readonly string allowForward = "http://schemas.microsoft.com/mapi/id/{00062040-0000-0000-C000-000000000046}/0C0F000B";
        //public static readonly string allowForward = "http://schemas.microsoft.com/exchange/ForwardAllowed";

        public static DateTimeFormatInfo dateFormats = CultureInfo.CurrentCulture.DateTimeFormat;
        public static Dictionary<string, string> TimeZones = new Dictionary<string, string>();

        public static readonly DateTime MinDate = new DateTime(2099, 12, 31);
        public static readonly DateTime MaxDate = new DateTime(1900, 1, 1);

        static MeetingParameters()
        {
            foreach (TimeZoneInfo tmZn in TimeZoneInfo.GetSystemTimeZones())
                TimeZones.Add(tmZn.Id, tmZn.DisplayName);
        }

        public static void GetTimes(DateTime dt, out int start, out int end)
        {
            if (dt.Minute > 30)
            {
                start = (dt.Hour + 1) * 2;
                end = (dt.Hour + 1) * 2 + 1;
            }
            else
            {
                start = (dt.Hour) * 2 + 1;
                end = (dt.Hour + 1) * 2;
            }
            // rollover towards midnight
            start %= MeetingTimes.Length;
            end %= MeetingTimes.Length;
        }
               
    }
}
