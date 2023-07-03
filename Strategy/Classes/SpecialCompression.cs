using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Classes
{
     public class SpecialCompression : ICompression
    {
        public void CompressFolder(string compressedArchiveFileName)
        => Console.WriteLine("Folder is compressed using Special approach: '" 
            + compressedArchiveFileName + ".spc' file is created");
    }
}
