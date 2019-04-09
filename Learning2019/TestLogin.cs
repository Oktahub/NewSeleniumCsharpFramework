using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Learning2019
{
    [TestClass]
    public class TestLogin
    {

        [TestMethod]
        public void VerifyLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.twitter.com/login");

            LoginPage login = new LoginPage(driver);
            login.TypeUsername();
            login.TypePassword();
            login.ClickLoginBtn();

            Thread.Sleep(5000);
            driver.Quit();

        }
    }
}
