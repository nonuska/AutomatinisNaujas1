using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using AutomatinisNaujas1.Page;

namespace AutomatinisNaujas1.Test
{
    public class CheckboxDemoTest : BaseTest
    {


        [Order(3)]
        [Test]
        public void TestSingleCheckBox()
        {
            _checkBoxDemoPage.NavigateToDefaultPage()
                .CheckSingleCheckbox()
                .CheckResult();
        }
        [Order(1)]
        [Test]
        public void TestCheckAllCheckboxes()
        {
            _checkBoxDemoPage.NavigateToDefaultPage()
                .CheckAllCheckboxes()
                .CheckButtonValue("Uncheck All");
        }
        [Order(2)]
        [Test]
        public void TestUncheckAllCheckboxes()
        {
            _checkBoxDemoPage.NavigateToDefaultPage()
                .CheckAllCheckboxes()
                .ClickButton()
                .VerifyThatAllCheckboxesAreUnchecked();
        }
    }
}
