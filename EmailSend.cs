using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class EmailSend : IEmailAlert
    {
        public string FromEmail { get; set; }
        public void ConfigureEmail(string destination)
        {

        }
        public void Send(string message)
        {

        }
        public bool Validation(string email)
        {

            return false;
        }
    }
}
