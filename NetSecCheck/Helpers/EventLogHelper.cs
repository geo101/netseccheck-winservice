using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;


namespace SecEventChecker.Helpers
{
   
    public class EventLogHelper
    {
        private string evlSource = "SecEventSrc";
        private string evlLog = "SecEvtXLog";
        private EventLog el;

        public EventLogHelper()
        {
            el = new EventLog();
            el.Source = evlSource;
            el.Log = evlLog;
        }
        public void log(string msg) 
        {
            el.WriteEntry(msg);
        }
        public void logerr(string msg) 
        {
            el.WriteEntry(msg, EventLogEntryType.Error);
        }
        
    }
}