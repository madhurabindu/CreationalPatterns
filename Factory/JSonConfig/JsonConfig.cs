using Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSonConfiguration
{
    public class JsonConfig : IConfig
    {
        public void Open(string connectionString)
        {
        }

        public string ReadAll()
        {
            // read config from a json file
            return "Json File config";
        }

        public void WriteAll(string blob)
        {

        }
    }
}
