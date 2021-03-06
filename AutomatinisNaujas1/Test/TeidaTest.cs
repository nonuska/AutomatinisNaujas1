using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisNaujas1.Test
{
    public class TeidaTest
    {
        private static IWebDriver _page;

        [OneTimeSetUp]
        public static void SetUp()
        {
           IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            _page = new TeidaPagrindinisPage1(driver);

            IWebElement Cookies = driver.FindElement(By.CssSelector(".cc - btn cc - dismiss"));
            wait.Until(d => popUp.Displayed);
            Cookies.Click();
        }


        [OneTimeTearDown]
        public static void TearDown()
        {
            //_driver.Quit();
        }


    }
}
