using System.Configuration;

namespace SecEventChecker.ConfSects
{
    public sealed class CustomConfigSection : ConfigurationSection
    {
        /* https://msdn.microsoft.com/en-us/library/system.configuration.configurationsection(v=vs.110).aspx */
        private static ConfigurationPropertyCollection _Properties;

        private static bool _ReadOnly;

        private static readonly ConfigurationProperty _Interval =
            new ConfigurationProperty("interval",
                typeof(int), null,
                ConfigurationPropertyOptions.None);


        private static readonly ConfigurationProperty _Timespan =
            new ConfigurationProperty("timespan",
                typeof(int), null,
                ConfigurationPropertyOptions.None);


        private static readonly ConfigurationProperty _From =
            new ConfigurationProperty("efrom",
                typeof(string), null,
                ConfigurationPropertyOptions.None);

        private static readonly ConfigurationProperty _To =
                    new ConfigurationProperty("eto",
                        typeof(string), null,
                        ConfigurationPropertyOptions.None);

        private static readonly ConfigurationProperty _Subj =
                    new ConfigurationProperty("esubj",
                        typeof(string), null,
                        ConfigurationPropertyOptions.None);

        private static readonly ConfigurationProperty _SMTP =
            new ConfigurationProperty("esmtp",
                typeof(string), null,
                ConfigurationPropertyOptions.None);

        private static ConfigurationProperty _ConnectionString =
            new ConfigurationProperty("connectionString",
            typeof(string), null,
            ConfigurationPropertyOptions.IsRequired);

        private static ConfigurationProperty _EventDictFile =
            new ConfigurationProperty("eventdictfile",
            typeof(string), null,
            ConfigurationPropertyOptions.IsRequired);

        private static ConfigurationProperty _EventsImportFile =
           new ConfigurationProperty("eventsimportfile",
           typeof(string), null,
           ConfigurationPropertyOptions.IsRequired);
        
        public CustomConfigSection()
        {
            _Properties = new ConfigurationPropertyCollection();
            _Properties.Add(_Interval);
            _Properties.Add(_Timespan);
            _Properties.Add(_From);
            _Properties.Add(_To);
            _Properties.Add(_Subj);
            _Properties.Add(_SMTP);
            _Properties.Add(_ConnectionString);
            _Properties.Add(_EventDictFile);
            _Properties.Add(_EventsImportFile);
        }

        protected override ConfigurationPropertyCollection Properties
        {
            get
            {
                return _Properties;
            }
        }

        private new bool IsReadOnly { get { return _ReadOnly; } }

        private void ThrowIfReadOnly(string propName)
        {
            if (IsReadOnly){
                throw new ConfigurationErrorsException("The property " + propName + " is read only.");
             }
        }

        protected override object GetRuntimeObject()
        {
            _ReadOnly = true;
            return base.GetRuntimeObject();
        }
        
        public int Interval
        {
            get { return (int)this["interval"]; }
            set
            {
                ThrowIfReadOnly("Interval");
                this["interval"] = value;
            }
        }

        public int Timespan
        {
            get { return (int)this["timespan"]; }
            set
            {
                ThrowIfReadOnly("timespan");
                this["timespan"] = value;
            }
        }

        public string From
        {
            get { return (string)this["efrom"]; }
            set
            {
                this["efrom"] = value;
            }
        }
        public string To
        {
            get { return (string)this["eto"]; }
            set
            {
                this["eto"] = value;
            }
        }
        public string Subj
        {
            get { return (string)this["esubj"]; }
            set
            {
                this["esubj"] = value;
            }
        }
        public string SMTP
        {
            get { return (string)this["esmtp"]; }
            set
            {
                this["esmtp"] = value;
            }
        }

        public string ConnectionString
        {
            get { return (string)this["connectionString"]; }
            set
            {
                this["connectionString"] = value;
            }
        }
        public string EventDictFile
        {
            get { return (string)this["eventdictfile"]; }
            set
            {
                this["eventdictfile"] = value;
            }
        }
        public string EventsImportFile
        {
            get { return (string)this["eventsimportfile"]; }
            set
            {
                this["eventsimportfile"] = value;
            }
        }

        

    }
}
