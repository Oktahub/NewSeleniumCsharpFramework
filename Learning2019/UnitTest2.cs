using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Learning2019
{
    [TestFixture]
    public class UnitTest2
    {
        public IWebDriver driver;

        [SetUp]
        public void init()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void NavigateToGoogle()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();

            System.Threading.Thread.Sleep(5000);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
