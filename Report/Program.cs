using Reports.Classes;
using Reports.Intrfaces;
using System.Reflection.PortableExecutable;

namespace Reports
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Design patterns: Builder, Dependency Injection using classes or records\n");

            Test2();
        }
        static void Test2()
        {
            var pdfBuilder = new PDFBuilderRec();
            var excelBuilder = new ExcelBuilderRec();
            var specialBuilder = new SpecialBuilderRec();

            //DI: constructor injection
            Console.WriteLine($"Constructor Dependency Injection \n");
            var director = new RecordDirector(pdfBuilder);
            var report = director.MakeReport();
            Console.WriteLine($"{report}");

            Console.WriteLine($"Property Dependency Injection \n");
            director.Builder = excelBuilder;
            report = director.MakeReport();
            Console.WriteLine($"{report}");

            Console.WriteLine($"Parameter Dependency Injection \n");
            report = director.MakeReport(specialBuilder);
            Console.WriteLine($"{report}");
        }
            static void Test1()
        {
            var pdfBuilder = new PDFbuilder();
            var excelBuilder = new ExcelBuilder();
            var specialBuilder = new SpecialBuilder();

            //DI: constructor injection
            var director = new ReportDirector(pdfBuilder);
            var report = director.MakeReport();
            report.DisplayReport();
            Console.WriteLine();

            //DI: property injection
            director.Builder = excelBuilder;
            report = director.MakeReport();
            report.DisplayReport();
            Console.WriteLine();

            //DI: Parameter injection
            report = director.MakeReport(specialBuilder);
            report.DisplayReport();
            Console.WriteLine();     
        }
        static void Test()
        {
            var pdfBuilder = new PDFbuilder();
            ReportDirector reportDirector = new ReportDirector();
            Report report = reportDirector.MakeReport(pdfBuilder);
            report.DisplayReport();
            Console.WriteLine();
            
            ExcelBuilder excelBuilder = new ExcelBuilder();
            report = reportDirector.MakeReport(excelBuilder);
            report.DisplayReport();          
        }
    }
}