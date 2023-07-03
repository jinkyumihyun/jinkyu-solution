using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsCommand.Classes
{
    public class Document
    {
        string _name;

        public Document(string name)
        {
            _name = name;
        }

        public void Open(int intParam)
        {
            Console.WriteLine($"{_name}: {intParam}: Document Opened");
        }
        public void Edit(string strParam)
        {
            Console.WriteLine($"{_name}: {strParam}: Document Edited");
        }
        public void Save(bool boolParam)
        {
            Console.WriteLine($"{_name}: {boolParam} Document Saved");
        }
        public void Close()
        {
            Console.WriteLine($"{_name}: Document Closed");
        }
    }
}
