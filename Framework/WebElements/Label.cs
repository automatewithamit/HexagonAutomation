using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.WebElements
{
    /// <summary>
    /// Wrapper Class over Button WebElement
    /// </summary>
    public class Label
    {
        public By Locator { get; set; }


        public Label(By locator)
        {
            this.Locator = locator;
        }

        public string GetLabelText()
        {
            return ElementUtil.GetText(Locator);
        }

        




    }
}
