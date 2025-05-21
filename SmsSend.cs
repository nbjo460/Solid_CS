using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class SmsSend : ISmsAlert
    {
        public string FromSms { get; set; }
        
        public void Send(string message)
        {

        }

        public void ConfigureSms(string destination)
        {

        }
        public bool Validation(string SmsNumber)
        {
            return false;
        }
    }
}
