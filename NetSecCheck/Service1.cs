using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Timers;
using System.Text;
using System.Threading.Tasks;
using SecEventChecker.Singletons;
using SecEventChecker.ConfSects;
using System.Configuration;
using SecEventChecker.Models;
using SecEventChecker.Helpers;

namespace SecEventChecker
{
    public partial class SecEventChecker : ServiceBase
    {		
        private List<EventItem> srcEvents;
        private int interval;
        private DataInHelper dih;
        private string eventdictfile = "";
        private string eventsimportfile = "";
        private CustomConfigSection section;
        public SecEventChecker()
        {
            section = ConfigurationManager.GetSection("appsettings") as CustomConfigSection;
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            initStuff();
            timer1.Interval = interval * 1000;
            timer1.Enabled = true;
        }

        protected override void OnStop()
        {
        }

        public void initStuff() {
            interval = section.Interval;
            eventdictfile = section.EventDictFile;
            eventsimportfile = section.EventsImportFile;
            dih = new DataInHelper();
            List<EventItem> evis = dih.GetEventItemData(eventdictfile);
            srcEvents = evis;
        }


        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            processEvent();
        }


        public void processEvent()
        {
            //eventLog1.WriteEntry("Fire!");
            if (!lProcessing)
            {
                lProcessing = true;
                bool lIssue = false;
                // stuff
                List<WinLogEvent> wles = dih.GetWinLogEventData(eventsimportfile);

                // traverse win log and make list of things to send to xmlizer
                foreach (WinLogEvent wle in wles) {
                    EventItem currwle = srcEvents.Where(x => x.EventID == wle.EventID && x.EventScope == "Windows").First();
                    string desc = currwle.EventDesc;

                    wle.EventDesc = desc;
                }               

                // now gen the xml data to stream.

                
                lProcessing = false;
            }
        }        
    }
}
