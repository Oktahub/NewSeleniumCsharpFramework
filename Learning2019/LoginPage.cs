using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning2019
{
    public class LoginPage
    {
        IWebDriver driver;
        By Username = By.ClassName("");
        By Password = By.ClassName("");
        By login_button = By.XPath("");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void TypeUsername()
        {
            driver.FindElement(Username).SendKeys("");
        }

        public void TypePassword()
        {
            driver.FindElement(Password).SendKeys("");
        }

        public void ClickLoginBtn()
        {
            driver.FindElement(login_button).Click();
        }
    }

    
}
