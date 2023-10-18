using Framework.WebElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.WorldoMeterPages
{
    public class WorldoMeterHomePage
    {
        SVG dailyDeathsChart = new SVG(By.XPath("(//h3[.='Daily New Deaths in India']/..//following::*[local-name()='svg'])[1]//*[local-name()='g' and contains(@class,'highcharts-dense-data')]//*[local-name()='rect']"));
        SVG activeCasesInIndiaChart = new SVG(By.XPath("(//h3[.='Active Cases in India']/..//following::*[local-name()='svg'])[1]//*[local-name()='g' and contains(@class,'highcharts-dense-data')]//*[local-name()='rect']"));

        public void GetSVGData()
        {
            List<string> dataList = dailyDeathsChart.GetData();
            foreach (var data in dataList)
            {
                
            }
        }

    }
}
