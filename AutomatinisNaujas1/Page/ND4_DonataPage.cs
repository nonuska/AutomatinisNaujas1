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
    
        public class ND4_DonataPage : BasePage
        {
            private const string PageAddress = "https://demo.seleniumeasy.com/basic-select-dropdown-demo.html";
            private const string FirstSelectedResultText = "First selected option is: ";
            private const string GetAllSelectedResultText = "Options selected are : ";
            private IWebElement FirstSelectedButton => Driver.FindElement(By.Id("printMe"));//cia pirmas mygtukas
            private IWebElement GetAllSelectedButton => Driver.FindElement(By.Id("printAll"));// antras mygtukas get all
            private SelectElement MultiND4_Donata => new SelectElement(Driver.FindElement(By.Id("multi-select")));
           
            public ND4_DonataPage(IWebDriver webdriver) : base(webdriver)

        {
            Driver.Url = PageAddress;
        }

       /* public ND4_DonataPage SelectByText(string text)
        {
            ND4_Donata.SelectByText(text);
            return this;
        }

        public ND4_DonataPage SelectByValue(string text)
        {
            ND4_Donata.SelectByValue(text);
            return this;
        }
       */
        public ND4_DonataPage SelectFromDuByValue(string firstValue, string secondValue)
        {
            Actions action = new Actions(Driver);
            MultiND4_Donata.SelectByValue(firstValue);
            action.KeyDown(Keys.Control);
            MultiND4_Donata.SelectByValue(secondValue);
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            return this;
        }

        public ND4_DonataPage SelectFromTrysByValue(string firstValue, string secondValue, string thirdValue)
        {
            Actions action = new Actions(Driver);
            MultiND4_Donata.SelectByValue(firstValue);
            action.KeyDown(Keys.Control);
            MultiND4_Donata.SelectByValue(secondValue);
            //action.KeyDown(Keys.Control); //REIKIA LAIKYTI KAIP APRASYTI
            MultiND4_Donata.SelectByValue(thirdValue);
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            return this;
        }
        public ND4_DonataPage SelectFromKeturiosByValue(string firstValue, string secondValue, string thirdValue, string fourthValue) //cia kazkaip ne taipPASISIURETI
        {
            Actions action = new Actions(Driver); 
            MultiND4_Donata.SelectByValue(firstValue);
            action.KeyDown(Keys.Control);
            MultiND4_Donata.SelectByValue(secondValue);
            // action.KeyDown(Keys.Control); // REIKIA LAIKTYTI
            MultiND4_Donata.SelectByValue(thirdValue);
          //action.KeyDown(Keys.Control); //REIKIA LAIKYTI
            MultiND4_Donata.SelectByValue(fourthValue);
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            return this;
        }

        public ND4_DonataPage ClickFirstSelectedButton()
        {
            FirstSelectedButton.Click();
            return this;
        }

        public ND4_DonataPage ClickAllSelectedButton()
        {
            GetAllSelectedButton.Click();
            return this;
        }

        public ND4_DonataPage SelectFromMultipleDropdownByValue(List<string> listOfStates)
        {
            MultiND4_Donata.DeselectAll();
            Actions action = new Actions(Driver);
            action.KeyDown(Keys.LeftControl);
            foreach (string state in listOfStates)
            {
                foreach (IWebElement option in MultiND4_Donata.Options)
                {
                    if (state.Equals(option.GetAttribute("value")))
                    {
                        action.Click(option);
                        break;
                    }
                }
            }
            action.KeyUp(Keys.LeftControl);
            action.Build().Perform();
            action.Click(FirstSelectedButton);
            action.Build().Perform();
            return this;
        }
        /*
        public ND4_DonataPage VerifyResult(string selectedStates)
        {
            Assert.IsTrue(FirstSelectedResultTextElement.Text.Equals(FirstSelectedResultText + selectedStates), $"Result is wrong, not {selectedStates}");
            return this;
        }

        public ND4_DonataPage VerifyResultAll(string selectedStates)
        {
            Assert.IsTrue(GetAllSelectedResultTexElement.Text.Equals(GetAllSelectedResultText + selectedStates), $"Result is wrong, not {selectedStates}");
            return this;
        }
        */

    }
}
