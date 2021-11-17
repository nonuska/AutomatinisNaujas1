using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisNaujas1.Test
{
    public class IevaPedkelnesTest
    {
        private static IevaPedkelnesTest _page;

        [OneTimeSetUp]
        public static void SetUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            _page = new IevaPedkelnesPage(driver);
        }

        [OneTimeTearDown]

        public static void TearDown()
        {
            _page.CloseBrowser();
        }

        //kitas psl blauzdines
        public IevaPedkelnesPage ClickStevenBlauzdinės068Button()
        {
            _StevenBlauzdinės068Button.Click();
            return this;

        }
        public IevaPedkelnesPage CheckAllCheckboxes()
        check
        }
        
        

    }
}
