using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace Learning2019
{
    [TestClass]
    public class LoginPageFactorytest
    {
        [TestMethod]
        public void VerifyTwitterLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.twitter.com/login");

            LoginPageFactory loginPF = new LoginPageFactory();
            PageFactory.InitElements(driver, loginPF);

            loginPF.Username.SendKeys("");
            loginPF.Password.SendKeys("");
            loginPF.ClickOnLoginButton();

            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
