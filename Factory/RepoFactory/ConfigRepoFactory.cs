using System;
using System.Text;
using Base.Interfaces;
using CSVConfiguration;
using JSonConfiguration;

namespace FactoryPattern.ConfigRepository
{
    /// <summary>
    /// Base creator class
    /// </summary>
    public abstract class ConfigRepoFactory
    {
        /// <summary>
        /// Factory Design pattern: Creator
        /// Instance of the concrete factory
        /// </summary>
        private static ConfigRepoFactory instance;
        /// <summary>
        /// static ctor
        /// </summary>
        static ConfigRepoFactory()
        {
            CreateNewRepository();
        }
        /// <summary>
        /// Accessor
        /// </summary>
        public static ConfigRepoFactory Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Derived classes contain the config
        /// </summary>
        /// <returns></returns>
        public abstract IConfig GetConfig();
        /// <summary>
        /// Create the right repo factory based on the application version
        /// </summary>
        private static void CreateNewRepository()
        {
            // Read App version here..
            string appVer = ApplicationProperties.AppVersion;

            if (appVer.StartsWith("1."))
            {
                // Older version of software, CSV format
                instance = new CSVRepoFactory();
            }
            else if (appVer.StartsWith("2."))
            {
                instance = new XMLRepoFactory();
            }
            else 
            {
                // newer version of software
                instance = new JSonRepoFactory();
            }
        }
    }

   

    
}
