using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using SecEventChecker.ConfSects;
using SecEventChecker.Models;
using SecEventChecker.Helpers;

namespace SecEventChecker.Singletons
{
    public class Checker
    {
        private string _lastLock = "";
        private DateTime _lastUdpate;
        private int _elapsedSeconds = 0;
        private TimeSpan _elapsedTimeSpan;
        private string _lockval = "";
        private string _user;
        private DateTime ? _lastDateTime = null;
        private int _timepsan;

        public Checker() {
            CustomConfigSection section = ConfigurationManager.GetSection("appsettings") as CustomConfigSection;
            _timepsan = section.Timespan;
        }
        public DateTime getLastDateTime() {
            return (DateTime)_lastDateTime;
        }
        public int getElapsedSeconds() {
            return _elapsedSeconds;
        }
        public string getLockMessage()
        {
            string str = "";
            str = "Locked for : ";
            if (_elapsedTimeSpan.Days > 0)
                str = str + _elapsedTimeSpan.Days.ToString() + " days ";
            if (_elapsedTimeSpan.Hours > 0)
                str = str + _elapsedTimeSpan.Hours.ToString() + " hours ";
            if (_elapsedTimeSpan.Minutes > 0)
                str = str + _elapsedTimeSpan.Minutes.ToString() + " minutes ";
            if (_elapsedTimeSpan.Seconds > 0)
                str = str + _elapsedTimeSpan.Seconds.ToString() + " seconds ";
            str = str + " with lock val of : [" + _lockval + "] AND user = " + _user + ".";
            return str;
        }
        public bool checkForLockIssue() {
            bool ret = false;
            string currLock = "";
            _lockval = "";
            DateTime currDTChange;
            DateTime now = DateTime.Now;
            _elapsedSeconds = 0;
            _elapsedTimeSpan = new TimeSpan(0);
            
            return ret;
        }
    }
}
