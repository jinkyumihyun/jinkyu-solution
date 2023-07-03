using FileSystemComposit.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemComposit.NewFolder
{
    public class DirectoryItem : AbstractFileSystemItem
    {
        private List<AbstractFileSystemItem> Children = new List<AbstractFileSystemItem>();
        public DirectoryItem(string name) : base(name) { }
        public void AddComponent(AbstractFileSystemItem item) 
            => this.Children.Add(item ?? throw new ArgumentNullException(nameof(item)));
        public void RemoveComponent(AbstractFileSystemItem item) => this.Children.Remove(item);
        public override decimal GetSize() => this.Children.Sum(x => x.GetSize());
    }
}

