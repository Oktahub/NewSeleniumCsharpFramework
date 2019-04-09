using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning2019
{
    [TestClass]
    public class FrameClass
    {
        IWebDriver driver;

        [TestMethod]
        public void TakeScreenshot()
        {
            try
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.twitter.com");
                driver.Manage().Window.Maximize();

                ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(DateTime.Now.ToShortDateString()+".png", ScreenshotImageFormat.Png);

            }

            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            finally
            {
                driver.Quit();
            }
        }
    }
}
