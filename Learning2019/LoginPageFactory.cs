using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning2019
{
    class LoginPageFactory
    {
        //PageFactory for Twitter login method
        //FindsBy
        //CacheLookup
        //How

        [FindsBy(How=How.ClassName, Using = "js-username-field")]
        //[CacheLookup]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.ClassName, Using = "js-password-field")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='page-container']")]
        public IWebElement login_button { get; set; }

        public void ClickOnLoginButton()
        {
            login_button.Click();
        }
    }
}
