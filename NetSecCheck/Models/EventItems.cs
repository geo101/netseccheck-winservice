using System;
using System.Data;

namespace SecEventChecker.Models
{
    public class EventItem
    {
        
        public string EventScope { get; set; }
        public int EventID { get; set; }
        public string EventDesc { get; set; }
        public EventItem() { }
        public EventItem(string scope, int myid, string desc) {
            EventScope = scope;
            EventID = myid;
            EventDesc = desc;
        }
       
    }
}