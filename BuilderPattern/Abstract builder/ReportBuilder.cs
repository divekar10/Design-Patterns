using BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Abstract_builder
{
    public abstract class ReportBuilder
    {
        protected Report _report;

        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();

        public void CreateNewReport()
        {
            _report = new Report();
        }

        public Report GetReport()
        {
            return _report;
        }

    }
}
