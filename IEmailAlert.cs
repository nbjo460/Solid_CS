using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal interface IEmailAlert : ISender
    {
        string FromEmail { get; set; }
        void ConfigureEmail(string destination);
    }
}
