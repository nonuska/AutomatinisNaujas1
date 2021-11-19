using NUnit.Framework;
using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatinisNaujas1.Drivers;
using AutomatinisNaujas1.Page;
//open selenium chrome

namespace AutomatinisNaujas1.Test
{
    public class DropDownTest : BaseTest
    {

        [Test]
        public void TestDropDown()
        {
            _dropDownPage.NavigateToDefaultPage()
                .SelectFromDropdownByText("Friday")
                .VerifyResult("Friday");
        }

        [TestCase("New Jersey", "California", TestName = "Pasirenkame 2 reiksmes ir patikriname pirma pasirinkima")]
        [TestCase("Washington", "Ohio", "Texas", TestName = "Pasirenkame 3 reiksmes ir patikriname pirma pasirinkima")]
        public void TestMultipleDropdown(params string[] selectedElements)
        {
            _dropDownPage.NavigateToDefaultPage()
                .SelectFromMultipleDropdownAndClickFirstButton(selectedElements.ToList())
                .CheckFirstState(selectedElements[0]);
        }

        [TestCase("New Jersey", "California", TestName = "Pasirenkame 2 reiksmes ir patikriname visus pasirinkimus")]
        [TestCase("Washington", "Ohio", "Texas", "Florida", TestName = "Pasirenkame 4 reiksmes ir patikriname visus pasirinkimus")]
        public void TestMultipleDropdownGetAll(params string[] selectedElements)
        {
            _dropDownPage.NavigateToDefaultPage()
                .SelectFromMultipleDropDownByValue(selectedElements.ToList())
                .ClickGetAllButton();
        }
    }
}
