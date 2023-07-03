using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Interfaces;

namespace Strategy.Classes
{
    public class CompressionContext
    {
        private ICompression Compression;
        public CompressionContext(ICompression Compression)
            => this.Compression = Compression ?? throw new ArgumentNullException(nameof(Compression));
        public void SetStrategy(ICompression Compression) 
            => this.Compression = Compression ?? throw new ArgumentNullException(nameof(Compression));
        public void CreateArchive(string compressedArchiveFileName)
            => Compression.CompressFolder(compressedArchiveFileName);
    }
}
