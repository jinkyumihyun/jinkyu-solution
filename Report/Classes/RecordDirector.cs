using Reports.Intrfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Classes
{
    public class RecordDirector
    {
        //dependency injection: constructor
        public RecordDirector(IReport builder)
        => Builder = builder ?? throw new ArgumentNullException(nameof(builder));
        public RecordDirector() { }

        //dependency injection: property
        public IReport Builder { get; set; }
     
        //dependency injection: parameter
        public IReport MakeReport(IReport builder) => builder.Get(); 
        public IReport MakeReport() => MakeReport(Builder);
    }
}
