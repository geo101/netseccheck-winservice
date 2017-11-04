using SecEventChecker.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SecEventChecker.Helpers
{ 
    public class DataInHelper
    {
        private string eventFile = "";

        public List<EventItem> GetEventItemData(string file) 
        {

            SetFile(file);
            var Lines = File.ReadLines(eventFile).Select(a => a.Split(';'));

            List <EventItem> eis = new List<EventItem>();
            foreach (var line in Lines) {
                var fields = ((string)line[0]).Split(',');
                eis.Add(new EventItem(fields[0],Convert.ToInt32(fields[1]), fields[2]));
            }

            return eis;

        }
        public List<WinLogEvent> GetWinLogEventData(string file)
        {
            SetFile(file);
            var Lines = File.ReadLines(eventFile).Select(a => a.Split(';'));

            List<WinLogEvent> wles = new List<WinLogEvent>();
            foreach (var line in Lines)
            {
                var fields = ((string)line[0]).Split(',');
                wles.Add(new WinLogEvent(fields[0], Convert.ToInt32(fields[1]), Convert.ToDateTime(fields[2])));
            }

            return wles;

        }
        public void SetFile(string file) {
            eventFile = file;
        }
        
    }
}