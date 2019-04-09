using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using NUnit.Framework;

namespace Learning2019
{
    [TestFixture]
    [Parallelizable]
    public class NunitParallelTest :Base
    {
        [Test]
        public void SearchGoogle()
        {
            //driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.goolgle.com");
            driver.FindElement(By.Name("q")).SendKeys("Ness");
            driver.FindElement(By.Name("btnK")).Click();

            System.Threading.Thread.Sleep(5000);
        }

        [Test]
        public void SearchGoogle1A()
        {
            //driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.goolgle.com");
            driver.FindElement(By.Name("q")).SendKeys("Digital");
            driver.FindElement(By.Name("btnK")).Click();

            System.Threading.Thread.Sleep(5000);
        }
    }

    [TestFixture]
    [Parallelizable]
    public class NunitParallelTest2 : Base
    {
        [Test]
        public void SearchGoogle2()
        {
            //driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.goolgle.com");
            driver.FindElement(By.Name("q")).SendKeys("Tech");
            driver.FindElement(By.Name("btnK")).Click();

            System.Threading.Thread.Sleep(5000);
        }
    }
}
