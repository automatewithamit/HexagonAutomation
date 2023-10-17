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



        public void searchForFlights(string from,string to, string departOn,string returnOn)
        {
            fromTextBox.SetText(from,true);
            Thread.Sleep(3000);
            toTextBox.SetText(to, true);
            Thread.Sleep(3000);
        }


    }
}
