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


        public Calendar(By locator)
        {
            this.Locator = locator;
        }
    }
}
