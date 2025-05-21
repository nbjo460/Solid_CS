﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal interface ISmsAlert : ISender
    {
        string FromSms { get; set; }
        void ConfigureSms(string destination);
    }
}
