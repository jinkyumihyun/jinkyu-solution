using Reports.Intrfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Classes
{
    public class ReportDirector
    {
        //dependency injection: constructor
        public ReportDirector(AbstractBuilder builder)
        => Builder = builder ?? throw new ArgumentNullException(nameof(builder));
        public ReportDirector() { }

        //dependency injection: property
        public AbstractBuilder Builder { get; set; }

        //dependency injection: parameter
        public Report MakeReport(AbstractBuilder builder)
        {
            builder.CreateReport();
            builder.SetReportType();
            builder.SetReportHeader();
            builder.SetReportContent();
            builder.SetReportFooter();
            return builder.GetReport();
        }
        public Report MakeReport() => MakeReport(Builder);
    }
}
