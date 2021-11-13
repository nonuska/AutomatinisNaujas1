using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisNaujas1.Page
{
    public class DropDownPage : BasePage //butinai public ir susilinkint ssu basepage (1)
    {
        private const string PageAddress = "https://demo.seleniumeasy.com/basic-select-dropdown-demo.html"; //(1)konstanta yra, psl adresas yra//BUTINAI pries kabutes tarpelis
        private const string ResultText = "Day selected :- "; //(2)cia tas tekstas kuris nuspaudus mygtuka po juo buna kur nesikeicia pirma sakinio dalis(2)
        private SelectElement DropDown => new SelectElement(Driver.FindElement(By.Id("select-demo"))); //cia jau nebe IWebElementas o selectelement dropdown//kintamasis dropdown//DRiveri, kuris yra base klaseje surak mum elementa
        private IWebElement ResultTextElement => Driver.FindElement(By.CssSelector(".selected-value")); //(3) PVZ  day selecte : tuesday
        private IWebElement FirstSelectedButton => Driver.FindElement(By.Id("printMe")); //(5) pirmas mygtumas tas First selected, kur pauspaudus daug valstyb ir mygtuka pasp suranda pirmaja
        private IWebElement GetAllSelectedButton => Driver.FindElement(By.Id("printAll")); //(6) tas kitas mygtukas  GET ALL SELECTED
        private SelectElement MultiDropDown => new SelectElement(Driver.FindElement(By.Id("multi-select"))); //(4)cia tas didelis blokas multi, kur surasytos valstybes
        public DropDownPage(IWebDriver webdriver) : base(webdriver) //cia musu driveris, cia susisieja musu klases ,kontruktorius (1)
        {
            Driver.Url = PageAddress;
        }

        public DropDownPage SelectFromDropdownByText(string text) //text tai buitiskai, bet reiketu rasyti value(1)
        {
            DropDown.SelectByText(text); 
            return this;
        }

        public DropDownPage SelectFromDropdownByValue(string text) //(1)
        {
            DropDown.SelectByValue(text);
            return this;
        }

        public DropDownPage SelectFromMultiDropDownByValue(string firstValue, string secondValue) //(4) cia tam multi kuriam metoda
        {
            Actions action = new Actions(Driver); //Driver butinai taip kaip base klaseje
            MultiDropDown.SelectByValue(firstValue);
            action.KeyDown(Keys.Control); //keys tie mygtukai kurie yra klaviaturoje//control Ctrl leidzia uzfiksuoja ir leidzia antra reiksme pasirinkti
            MultiDropDown.SelectByValue(secondValue);
            action.KeyUp(Keys.Control); //noriu kad mygtukas atsispaustu kad ctrl atsispasutu
            action.Build().Perform(); //vykdom sita veiksma
            return this;
        }

        public DropDownPage ClickFirstSelectedButton() //(6) pasirinkti pirma mygtuka metodas
        {
            FirstSelectedButton.Click(); //cia jau ne dropdown todel click
            return this;
        }

        public DropDownPage ClickAllSelectedButton() //(7) ta kita mygtuka paudziu
        {
            GetAllSelectedButton.Click();
            return this;
        }

        public DropDownPage SelectFromMultipleDropdownByValue(List<string> listOfStates)
        {
            MultiDropDown.DeselectAll(); //kad mygtukas butu atzymetas , kad nepazymetas
            Actions action = new Actions(Driver);
            action.KeyDown(Keys.LeftControl); //left control kad uzspaudus laikom
            foreach (string state in listOfStates) //iskvieciam kaip masyva //musu valstijos musu valstiju sarase
            {
                foreach (IWebElement option in MultiDropDown.Options)
                {
                    if (state.Equals(option.GetAttribute("value"))) //elementas mulpidropdown opcijoje
                    {
                        action.Click(option);
                        break;
                    }
                }
            }
            action.KeyUp(Keys.LeftControl); //atspaudizam ctrl
            action.Build().Perform();
            action.Click(FirstSelectedButton); //pasirenkam prima mygtuka
            action.Build().Perform();
            return this;
        }

        public DropDownPage VerifyResult(string selectedDay) //(3)
        {
            Assert.IsTrue(ResultTextElement.Text.Equals(ResultText + selectedDay), $"Result is wrong, not {selectedDay}"); // rezultato teksta stas kur nekinta day selected:
            return this;
        }
    }
}