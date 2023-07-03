using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Classes
{
    public class Report
    {
        public string Type { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public string Footer { get; set; }     
        public void DisplayReport()
        {
            Console.WriteLine("Report Type:" + Type);
            Console.WriteLine("Report Header:" + Header);
            Console.WriteLine("Report Content:" + Content);
            Console.WriteLine("Report Footer:" + Footer);
        }
    }
}
