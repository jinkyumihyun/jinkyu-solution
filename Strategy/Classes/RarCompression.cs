using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Interfaces;

namespace Strategy.Classes
{
    public class RarCompression : ICompression
    {
        public void CompressFolder(string compressedArchiveFileName)
        => Console.WriteLine("Folder is compressed using Rar approach: '"
            + compressedArchiveFileName + ".rar' file is created");
    }
}
