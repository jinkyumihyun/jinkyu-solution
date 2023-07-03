using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemComposit.Interfaces
{
    public abstract class AbstractFileSystemItem
    {
        public string Name { get; }
        public AbstractFileSystemItem(string name) 
            => this.Name = IsNullWhite(name) ?? throw new ArgumentException(nameof(name));
        static string? IsNullWhite(string name) => string.IsNullOrWhiteSpace(name) ? null : name;
        public abstract decimal GetSize();
    }
}
