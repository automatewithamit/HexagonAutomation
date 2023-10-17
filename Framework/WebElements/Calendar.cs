using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.WebElements
{
    public class Calendar
    {
        public By Locator { get; set; }

        By byForward = By.XPath("//table[2]/thead//button");
        By byBackward = By.XPath("//table[1]/thead//button");

        public Calendar(By locator)
        {
            this.Locator = locator;
        }

        public void SelectDate(string targetDate)
        {

            ElementUtil.Click(Locator);
            var currentDate = DateTime.Now;
            DateTime endDate = Convert.ToDateTime(targetDate);
            int monthsDifference = ((endDate.Year - currentDate.Year) * 12) + endDate.Month - currentDate.Month;

            for (int i = 0; i < monthsDifference; i++)
            {
                ElementUtil.Click(byForward);
            }
            Thread.Sleep(3000);
            var day = targetDate.Split("/")[0];
            var byDay = By.XPath("(//button[text()='" + day + "'])[1]");
            ElementUtil.Click(byDay);
            Thread.Sleep(2000);

        }



        public void SelectDate(string departDate,string returnDate)
        {

            ElementUtil.Click(Locator);
            var currentDate = DateTime.Now;
            DateTime departDateTime = Convert.ToDateTime(departDate);

            int monthsDifference = ((departDateTime.Year - currentDate.Year) * 12) + departDateTime.Month - currentDate.Month;

            for (int i = 0; i < monthsDifference; i++)
            {
                ElementUtil.Click(byForward);
            }
            Thread.Sleep(3000);

            var departDay = departDate.Split("/")[0];
            var bydepartDay = By.XPath("(//button[text()='" + departDay + "'])[1]");
            ElementUtil.Click(bydepartDay);
            Thread.Sleep(2000);

        }




    }
}
