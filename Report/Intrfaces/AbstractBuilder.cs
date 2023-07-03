using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reports.Classes;

namespace Reports.Intrfaces
{
    public abstract class AbstractBuilder
    {
        protected Report report;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();
        public void CreateReport() => report = new Report();
        public Report GetReport() => report;
    }
}
