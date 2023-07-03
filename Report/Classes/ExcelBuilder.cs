using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reports.Intrfaces;

namespace Reports.Classes
{
    public class ExcelBuilder : AbstractBuilder
    {
        public override void SetReportContent() => report.Content = "Excel Content";
        public override void SetReportFooter() => report.Footer = "Excel Footer";
        public override void SetReportHeader() => report.Header = "Excel Header";
        public override void SetReportType() => report.Type = "Excel";
    }

    public record class ExcelBuilderRec(string Type = "", string Header = "", string Content = "", string Footer = "") : IReport
    {
        ExcelBuilderRec SetReportContent() => this with { Content = "Excel Content" };
        ExcelBuilderRec SetReportFooter() => this with { Footer = "Excel Footer" };
        ExcelBuilderRec SetReportHeader() => this with { Header = "Excel Header" };
        ExcelBuilderRec SetReportType() => this with { Type = "Excel" };
        public IReport Get()
        {
            return SetReportType().SetReportHeader().SetReportContent().SetReportFooter();
        }
    }
}
