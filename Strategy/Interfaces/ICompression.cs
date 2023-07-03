﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Interfaces
{
    public interface ICompression
    { 
        void CompressFolder(string compressedArchiveFileName); 
    }
}
