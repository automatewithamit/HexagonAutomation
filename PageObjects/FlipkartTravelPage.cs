using Framework.WebElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class FlipkartTravelPage
    {
        //TextBox fromTextBox = new TextBox(By.XPath("//input[@name='0-departcity'] || (//div[text()='HYD'])[1]"));
        TextBox fromTextBox = new TextBox(By.XPath("//input[@name='0-departcity']"));
        TextBox toTextBox = new TextBox(By.XPath("//input[@name='0-arrivalcity']"));
        Calendar departOnCalendar = new Calendar(By.XPath("//input[@name='0-datefrom']"));
        Calendar returnOnCalendar = new Calendar(By.XPath("//input[@name='0-dateto']"));

        Button searchButton = new Button(By.XPath("//span[normalize-space()='SEARCH']"));


        public void searchForFlights(string from, string to, string departOn, string returnOn = "")
        {
            fromTextBox.SetText(from, true);
            Thread.Sleep(3000);
            toTextBox.SetText(to, true);
            Thread.Sleep(3000);
            departOnCalendar.SelectDate(departOn);
            if (!string.IsNullOrEmpty(returnOn))
            {
                returnOnCalendar.SelectDate(returnOn);
            }
            Thread.Sleep(2000);
            searchButton.Click();
            Thread.Sleep(5000);
        }

        public void selectDepartAndReturnDates()
        {

        }
    }
}
