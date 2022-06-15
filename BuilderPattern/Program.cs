using BuilderPattern.Concrete_Builder;
using BuilderPattern.Director;
using BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Report report;
            //ReportDirector reportDirector = new ReportDirector();

            //PdfReport pdfReport = new PdfReport();
            //report = reportDirector.MakeReport(pdfReport);
            //report.DisplayReport();
            //Console.WriteLine("==================================");
            //ExcelReport excelReport = new ExcelReport();
            //report = reportDirector.MakeReport(excelReport);
            //report.DisplayReport();

            Beverage beverage;
            BeverageDirector beverageDirector = new BeverageDirector();
            Console.WriteLine("Let's make a tea..");
            TeaBuilder tea = new TeaBuilder();
            beverage = beverageDirector.MakeBeverage(tea);
            Console.WriteLine(beverage.ShowBeverage());

            //CoffeeBuilder coffee = new CoffeeBuilder();
            //beverage = beverageDirector.MakeBeverage(coffee);
            //Console.WriteLine(beverage.ShowBeverage());

            Console.ReadKey();

        }
    }
}
