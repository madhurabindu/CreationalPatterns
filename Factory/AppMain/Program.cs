using Base.Interfaces;
using FactoryPattern.ConfigRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMain_FactoryPattern
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Enter the version of the app to mimic the different app versions. Format majorversion.minorversion.x :");
            string input = Console.ReadLine();

            IConfig config = ConfigRepoFactory.Instance.GetConfig(input);

            string configData = config.ReadAll();
            Console.WriteLine("Config read: {0}", configData);
        }
    }
}
