using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Reporting
{
    public class ExtentReport
    {
        public ExtentReports extent;

        public static ExtentTest Log;

        public ExtentReports CreateReport()
        {

            string path = Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            string reportPath = projectPath + "\\ExecutionReports\\HexagonAutomationReport.html";
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(reportPath);


            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Host Name", "Amit Tripathi");
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("User Name", "AutomateWithAmit");
            //extentprojectPath + "extent-config.xml");
            return extent;
        }


    }
}
