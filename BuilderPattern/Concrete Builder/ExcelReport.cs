using BuilderPattern.Abstract_builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Concrete_Builder
{
    class ExcelReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            _report.ReportContent = "Excel Content section";
        }

        public override void SetReportFooter()
        {
            _report.ReportFooter = "Excel Footer";
        }

        public override void SetReportHeader()
        {
            _report.ReportHeader = "Excel Header";
        }

        public override void SetReportType()
        {
            _report.ReportType = "Excel";
        }
    }
}
