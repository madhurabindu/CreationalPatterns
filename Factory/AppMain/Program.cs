using System;
using Base.Interfaces;
using FactoryPattern.ConfigRepository;

namespace AppMain_FactoryPattern
{
    // Class to mimic a older client code of the repository
    public class Client
    {
        /// <summary>
        /// Config
        /// </summary>
        IConfig config;
        /// <summary>
        /// Client Ctor
        /// </summary>
        public Client()
        {
            // Initialize theconfig
            config = ConfigRepoFactory.Instance.GetConfig();
        }

        /// <summary>
        /// Some operation that needs to access config
        /// </summary>
        public void SomeOperation()
        {
            Console.WriteLine("<--- In Client {0}--->", ApplicationProperties.AppVersion);
            string configData = config.ReadAll();
            Console.WriteLine("Config read: {0}", configData);
            Console.WriteLine("Clinet is not aware of the concrete class of the config!");
        }
    }


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            // Change App version to mimic the bahviour of new client
            // 1.* is CSV, 2.* is XML and any other is JSON
            ApplicationProperties.AppVersion = "3.2.3";

            Client client = new Client();
            client.SomeOperation();

            // New version does not need change to client, older repos
            // Only requires a new factory to be created and a new repo to be added
        }

    }
}
