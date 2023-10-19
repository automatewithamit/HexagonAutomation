using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.WebElements
{
    public class Canvas
    {
        public By Locator { get; set; }
        public Canvas(By locator)
        {
            this.Locator = locator;
        }
        public void GetCanvasData()
        {


            Actions builder = new Actions(DriverManager.driver);
            Thread.Sleep(5000);
            var element = DriverManager.driver.FindElement(Locator);
            //var element = DriverManager.driver.FindElement(By.XPath("//button[@title='My Timesheet']"));
            builder.MoveToElement(element).Perform();
            ((IJavaScriptExecutor)DriverManager.driver).ExecuteScript("arguments[0].scrollIntoView();", element);

            List<(double x, double y)> coordinates = GetCoordinatesOnCircle();
            foreach (var coordinate in coordinates)
            {
                // Convert the double values to integers if needed
                int x = (int)coordinate.x;
                int y = (int)coordinate.y;

                // Use the x and y coordinates in the MoveToElement method

                builder.MoveToElement(element, x, y).Perform();

                var tooltipElement = DriverManager.driver.FindElement(By.XPath("//span[@id='oxd-pie-chart-tooltip']"));
                Console.WriteLine(tooltipElement.Text);

            }
            //builder.MoveToElement(element, (int)x, (int)y).Perform();



            Thread.Sleep(5000);
        }
        public List<(double x, double y)> GetCoordinatesOnCircle()
        {
            double radius = 10; // Fixed radius
            List<(double x, double y)> coordinates = new List<(double x, double y)>();

            for (int angleInDegrees = 0; angleInDegrees <= 360; angleInDegrees++)
            {
                double angleInRadians = Math.PI * angleInDegrees / 180.0;
                double x = radius * Math.Cos(angleInRadians);
                double y = radius * Math.Sin(angleInRadians);
                coordinates.Add((x, y));
            }

            return coordinates;
        }
        public (double x, double y) GetCoordinatesOnCircle_old()
        {
            var radius = 20;
            double angleInDegrees = 0;
            for (int i = 0; i <= 360; i++)
            {
                angleInDegrees = i;
            }
            double angleInRadians = Math.PI * angleInDegrees / 180.0;
            double x = radius * Math.Cos(angleInRadians);
            double y = radius * Math.Sin(angleInRadians);
            return (x, y);
        }

    }
}
