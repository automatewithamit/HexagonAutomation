using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class DriverManager
    {
        [ThreadStatic]
        public static IWebDriver driver;

    }
}
