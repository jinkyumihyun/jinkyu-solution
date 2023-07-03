using FileSystemComposit.Interfaces;
using HelperLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemComposit.NewFolder
{
    public class FileItem : AbstractFileSystemItem
    {
        public long FileBytes { get; }       
        private FileItem(string name, long fileBytes) : base(name)
            => this.FileBytes = fileBytes;
        public static AbstractFileSystemItem Create(string name, long fileBytes)
      => (Helper.IsNullWhite(name), Helper.IsZeroNegative((int)fileBytes)) switch
      {
          (null, _) => throw new ArgumentException(nameof(Name)),
          (_, null) => throw new ArgumentException(nameof(fileBytes)),
          (_, _) => new FileItem(name, fileBytes)
      };
        public override decimal GetSize() => FileBytes;
    }
}
