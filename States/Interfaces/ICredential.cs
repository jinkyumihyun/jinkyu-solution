﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Interfaces
{
    public interface ICredential
    {
        bool Check(string user, string password);
        bool Add(string user, string password);
    }
}
