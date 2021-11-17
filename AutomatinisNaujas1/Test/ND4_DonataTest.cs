using AutomatinisNaujas1.Page;
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
    public class ND4_DonataTest
    {
        private static ND4_DonataPage _page;



        [OneTimeSetUp]
        public static void SetUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            _page = new ND4_DonataPage(driver);
        }

        [OneTimeTearDown]

        public static void TearDown()
        {
            _page.CloseBrowser();
        }


        [TestCase("California", "New York", TestName = "First selected option is : California")]

        public void TestStatesSelectFromDuByValue(string firstValue, string secondValue)
        {
            _page.SelectFromDuByValue("California", "New York")
            .ClickFirstSelectedButton();
        }

        [TestCase("California", "New York", TestName = "Options selected are : California,New York")]

        public void TestStatesSelectFromDuByValueGetAllSelected(string firstValue, string secondValue)

        {
            _page.SelectFromDuByValue("California", "New York")
            .ClickAllSelectedButton();
        }

        [TestCase("California", "New York", "Texas", TestName = "First selected option is : California")]
        public void TestStatesSelectFromTrysByValueFirstSelected(string firstValue, string secondValue, string thirdValue)
        {
            _page.SelectFromTrysByValue("California", "New York", "Texas")
            .ClickFirstSelectedButton();
        }


        [TestCase("California", "New York", "Texas", "Washington", TestName = "Options selected are : California, New York, Texas, Pennsylvania, Washington")]
        public void TestStatesSelectFromKeturiosByValue(string firstValue, string secondValue, string thirdValue, string fourthValue)
        {
            _page.SelectFromKeturiosByValue("California", "New York", "Texas", "Washington")
            .ClickAllSelectedButton();
        }


    }
    }
