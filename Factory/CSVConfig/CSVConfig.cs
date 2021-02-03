using Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVConfiguration
{
    public class CSVConfig : IConfig
    {
        public void Open(string connectionString)
        {
        }

        public string ReadAll()
        {
            // read config from a csv file
            return "CSV File config";
        }

        public void WriteAll(string blob)
        {

        }
    }
}
