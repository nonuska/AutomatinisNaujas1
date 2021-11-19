using AutomatinisNaujas1.Drivers;
using AutomatinisNaujas1.Page;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatinisNaujas1.Drivers;
using AutomatinisNaujas1.Page;
using AutomatinisNaujas1.Tools;

namespace AutomatinisNaujas1.Test //sitame reikia susikkurtipo 1 nauja objekta kiekvienam is sukurtu puslapiu
{
    public class BaseTest
    {
        public static IWebDriver driver;
        public static DropDownPage _dropDownPage;
        public static VartuTechnikaPage _vartuTechnikaPage;
        public static SebPage _sebPage;

        [OneTimeSetUp]
        public static void SetUp()
        {
            driver = CustomDriver.GetChromeDriver();
            _dropDownPage = new DropDownPage(driver);
            _vartuTechnikaPage = new VartuTechnikaPage(driver);
            _sebPage = new SebPage(driver);
        }

        [TearDown]

        public static void TakeScreenshot() //metodas kuris bandys pagauti screenshot
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