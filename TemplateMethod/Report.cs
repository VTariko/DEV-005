using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Report
    {
        protected abstract string GetHeader();
        protected abstract string GetFooter();
        protected abstract string GetBody();

        public string GetReport()
        {
            var report = new StringBuilder();
            report.Append(GetHeader());
            report.Append(GetBody());
            report.Append(GetFooter());
            return report.ToString();
        }
    }
}
