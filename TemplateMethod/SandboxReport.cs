using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class SandboxReport: Report
    {
        protected override string GetHeader()
        {
            return "<h1>This is my report</h1>";
        }
        protected override string GetFooter() 
        {
            return DateTime.Now.ToString();
        }
        protected override string GetBody()
        {
            return "<p>test</p><p>test2</p>";
        }
    }
}
