using Reports.Intrfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Classes
{
    public class PDFbuilder : AbstractBuilder
    {
        public override void SetReportContent() =>  report.Content = "PDF Content";
        public override void SetReportFooter() => report.Footer = "PDF Footer";
        public override void SetReportHeader() => report.Header = "PDF Header";
        public override void SetReportType() => report.Type = "PDF";
    }
    public record class PDFBuilderRec(string Type = "", string Header = "", string Content = "", string Footer = "") : IReport
    {
        PDFBuilderRec SetReportContent() => this with { Content = "PDF Content" };
        PDFBuilderRec SetReportFooter() => this with { Footer = "PDF Footer" };
        PDFBuilderRec SetReportHeader() => this with { Header = "PDF Header" };
        PDFBuilderRec SetReportType() => this with { Type = "PDF" };
        public IReport Get()
        {
            return SetReportType().SetReportHeader().SetReportContent().SetReportFooter();
        }

    }
}
