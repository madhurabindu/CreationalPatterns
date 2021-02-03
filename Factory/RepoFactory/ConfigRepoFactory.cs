using System;
using System.Text;
using Base.Interfaces;
using CSVConfiguration;
using JSonConfiguration;

namespace FactoryPattern.ConfigRepository
{
    public class ConfigRepoFactory
    {
        private CSVConfig csvConfig;
        private JsonConfig jsonConfig;
        private static ConfigRepoFactory instance;

        static ConfigRepoFactory()
        {
            instance = new ConfigRepoFactory();
        }

        public static ConfigRepoFactory Instance
        {
            get { return instance; }
        }

        public IConfig GetConfig(string appVersion)
        {
            IConfig config = null;
            if (appVersion.StartsWith("1."))
            {
                if (csvConfig == null)
                {
                    csvConfig = new CSVConfig();
                }
                config = csvConfig;
            }
            else // version greater than 1.
            {
                if (jsonConfig == null)
                {
                    jsonConfig = new JsonConfig();
                }
                config = jsonConfig;
            }
            return config;
        }
    }
}
