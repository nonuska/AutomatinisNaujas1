using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatinisNaujas1.Page;

namespace AutomatinisNaujas1.Test
{
    public class DropDownTest //butinai public
    {
        private static DropDownPage _page; //susiejam su klase

        [OneTimeSetUp]
        public static void SetUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            _page = new DropDownPage(driver); //susiejam su dropdownpage
        }

        [OneTimeTearDown]

        public static void TearDown()
        {
            _page.CloseBrowser();
        }

        [Test]
        public void TestDropDown() //pirmas metodas buvo by text arba buy value
        {
            _page.SelectFromDropdownByText("Friday")
                .VerifyResult("Friday");
        }

        [Test]
        public void TestMultiDropDown() //cia pirma pagej susikuria (4),po to sita (7)
        {
            _page.SelectFromMultiDropDownByValue("Ohio", "Florida") //yrasome du value tai ohio, ir florida
                .ClickFirstSelectedButton(); //primiausia apsirasome pagej ta pirma mygtuka , po to antra , o mes siuo atveju norime paspausti pirma mygtuka FIRST SELECTED kad parodytu tik 1 valst


        }
        //ND

        [TestCase("California", "New York", TestName = "First selected option is : California")]
        [TestCase("California", "New York", TestName = "Options selected are : California,New York")]
        [TestCase("California", "New York", "Texas", TestName = "First selected option is : California")]
        [TestCase("California", "New York", "Texas", "Washington", TestName = "Options selected are : California, New York, Texas, Pennsylvania,Washington")]

        public void TestMultiDropDownValue()
        {

            _page.SelectFromMultiDropDownByValue(string valstyb1, string valstyb1, string valstyb1, string valstyb1);
            .ClickFirstSelectedButton();

            .ClickGetAllSelectedButton();


           
        }

    }
}