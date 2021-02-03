using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Interfaces
{
    public interface IConfig
    {
        void Open(string connectionString);
        string ReadAll();
        void WriteAll(string blob);
    }
}
