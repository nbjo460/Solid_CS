using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal interface ISender
    {
        void Send(string destination);
        bool Validation(string email);
    }
}
