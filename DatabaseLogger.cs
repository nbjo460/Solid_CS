using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class DatabaseLogger : ILogger
    {
        public void CreateLog(string destination, string message)
        {
        }
        public string ReadLog(string destination)
        {
            return "";
        }
    }
}
