using BuilderPattern.Abstract_builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Concrete_Builder
{
    class PdfReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            _report.ReportContent = "Pdf content section";
        }

        public override void SetReportFooter()
        {
            _report.ReportFooter = "Pdf footer";
        }

        public override void SetReportHeader()
        {
            _report.ReportHeader = "Pdf header";
        }

        public override void SetReportType()
        {
            _report.ReportType = "Pdf";
        }
    }
}
