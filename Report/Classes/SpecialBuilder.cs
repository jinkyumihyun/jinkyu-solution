using Reports.Intrfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Classes
{
    public class SpecialBuilder : AbstractBuilder
    {
        public override void SetReportContent() => report.Content = "Special Content";
        public override void SetReportFooter() => report.Footer = "Special Footer";
        public override void SetReportHeader() => report.Header = "Special Header";
        public override void SetReportType() => report.Type = "Special";
    }
    public record class SpecialBuilderRec(string Type = "", string Header = "", string Content = "", string Footer = "") : IReport
    {
        SpecialBuilderRec SetReportContent() => this with { Content = "Special Content" };
        SpecialBuilderRec SetReportFooter() => this with { Footer = "Special Footer" };
        SpecialBuilderRec SetReportHeader() => this with { Header = "Special Header" };
        SpecialBuilderRec SetReportType() => this with { Type = "Special" };
        public IReport Get()
        {
            return SetReportType().SetReportHeader().SetReportContent().SetReportFooter();
        }
    }
}
