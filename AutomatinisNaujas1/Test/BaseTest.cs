using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using AutomatinisNaujas1.Page;
using AutomatinisNaujas1.Tools;
using AutomatinisNaujas1.Drivers;

namespace AutomatinisNaujas1.Test
{
    public class BaseTest
    {
        public static IWebDriver driver;
        public static CheckboxDemoPage _checkBoxDemoPage;
        public static SeleniumInputPage _seleniumInputPage;
        public static DropDownPage _dropDownPage;
        public static VartuTechnikaPage _vartuTechnikaPage;
        public static SebPage _sebPage;
        public static VoverytesButikasLoginPage _loginPage;
        public static CheckOutPageAndShipping _checkoutPage;
        public static SenukaiPage _senukaiPage;
        public static AlertPage _alertPage;



        [OneTimeSetUp]
        public static void SetUp()
        {
            driver = CustomDriver.GetChromeDriver();
            //driver = CustomDriver.GetIncognitoChrome();
            _checkBoxDemoPage = new CheckboxDemoPage(driver);
            _dropDownPage = new DropDownPage(driver);
            _seleniumInputPage = new SeleniumInputPage(driver);
            _vartuTechnikaPage = new VartuTechnikaPage(driver);
            _sebPage = new SebPage(driver);
            _loginPage = new VoverytesButikasLoginPage(driver);
            _checkoutPage = new CheckOutPageAndShipping(driver);
            _senukaiPage = new SenukaiPage(driver);
            _alertPage = new AlertPage(driver);
        }

        [TearDown]

        public static void TakeScreenshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                MyScreenshot.MakeScreenshot(driver);
        }

        [OneTimeTearDown]

        public static void TearDown()
        {
            driver.Quit();
        }
    }
}