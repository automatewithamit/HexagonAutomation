using Framework.WebElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.OrangeHRMPages
{
    public class OrangeHRMDashboardPage
    {
        Canvas empDistributionBySubUnitCanvas = new Canvas(By.XPath("//p[text()='Employee Distribution by Sub Unit']/../..//following-sibling::div//canvas"));
        Canvas empDistributionByLocationCanvas = new Canvas(By.XPath("//p[text()='Employee Distribution by Location']/../..//following-sibling::div//canvas"));
        
        
        public void GetCanvasData()
        {
            //empDistributionBySubUnitCanvas.GetCanvasData();
            empDistributionByLocationCanvas.GetCanvasData();
        }

    }
}
