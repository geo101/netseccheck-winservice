using System;
using System.Data;

namespace SecEventChecker.Models
{
    public class WinLogEvent
    {
        
        public string Computer { get; set; }
        public int EventID { get; set; }
        public string EventDesc { get; set; }
        public DateTime EventDateTime { get; set; }
        public WinLogEvent() { }
        public WinLogEvent(string computer, int eventid, DateTime eventdatetime)
        {
            Computer = computer;
            EventID = eventid;
            EventDateTime = eventdatetime;
            EventDesc = "";
        }
        public WinLogEvent(string computer, int eventid, DateTime eventdatetime, string eventdesc) {
            Computer = computer;
            EventID = eventid;
            EventDateTime = eventdatetime;
            EventDesc = eventdesc;
        }
       
    }
}