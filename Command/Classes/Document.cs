using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Classes
{
    public class Document
    {
        string _name;
        public Document(string name) => _name = name;
        public void Open() => Console.WriteLine($"{_name}: Document Opened");
        public void Edit() => Console.WriteLine($"{_name}: Document Edited");
        public void Save() => Console.WriteLine($"{_name}: Document Saved");
        public void Close() => Console.WriteLine($"{_name}: Document Closed");
    }
}
