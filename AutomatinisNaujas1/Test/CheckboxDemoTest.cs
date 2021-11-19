using NUnit.Framework;
using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatinisNaujas1.Page;
using OpenQA.Selenium.Chrome;

namespace AutomatinisNaujas1.Test
{
    class CheckboxDemoTest
    {
        private static CheckboxDemoPage _page;

        [OneTimeSetUp]
        public static void SetUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            _page = new CheckboxDemoPage(driver);
        }

        [OneTimeTearDown]

        public static void TearDown()
        {
            _page.CloseBrowser();
        }

        [Order(3)]
        [Test]
        public void TestSingleCheckBox()
        {
            _page.CheckSingleCheckbox()
                .CheckResult();
        }
        [Order(1)]
        [Test]
        public void TestCheckAllCheckboxes()
        {
            _page.CheckAllCheckboxes()
                .CheckButtonValue("Uncheck All");
        }
        [Order(2)]
        [Test]
        public void TestUncheckAllCheckboxes()
        {
            _page.CheckAllCheckboxes()
                .ClickButton()
                .VerifyThatAllCheckboxesAreUnchecked();
        }
    }
}