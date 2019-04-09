using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Learning2019
{
    [TestClass]
    public class FirstTestClass
    {
        [TestMethod]
        public void ChromeMethod()
        {
            string ActualResult;
            string ExpectedResult = "Wikipedia";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.wikipedia.org");
            driver.Manage().Window.Maximize();

            List<string> CentralLanguages = new List<string>();
            ReadOnlyCollection<IWebElement> languages = driver.FindElements(By.ClassName("central-featured-lang"));
            foreach(IWebElement language in languages)
            {
                string lang = language.Text;
                lang = lang.Substring(0, lang.LastIndexOf("\r"));
                CentralLanguages.Add(lang);
            }
            string stop = "";

            Thread.Sleep(2000);
            SelectElement selectLanguage = new SelectElement(driver.FindElement(By.Id("searchLanguage")));
            selectLanguage.SelectByText("Deutsch");
            selectLanguage.SelectByValue("be");
            selectLanguage.SelectByIndex(0);
            
            #region
            List<String> textofanchors = new List<string>();
            ReadOnlyCollection<IWebElement> anchorLists = driver.FindElements(By.TagName("a"));
            foreach(IWebElement anchor in anchorLists)
            {
                if (anchor.Text.Length > 0)
                {
                    if (anchor.Text.Contains("English"))
                    {
                        textofanchors.Add(anchor.Text);
                        anchor.Click();
                    }
                    
                }
                
            }

            //driver.FindElement(By.Id("searchInput")).SendKeys("Selenium");
            //driver.FindElement(By.ClassName("pure-button")).Click();

            /*
            ActualResult = driver.Title;
            if (ActualResult.Contains(ExpectedResult))
            {
                Console.WriteLine("test case Passed !!!");
                Assert.IsTrue(true, "test case Passed !!!");
            }
            else
            {
                Console.WriteLine("test case Failed !!!");
            }
            */

            #endregion
            //driver.Close();
            driver.Quit();
        }
    }
}
