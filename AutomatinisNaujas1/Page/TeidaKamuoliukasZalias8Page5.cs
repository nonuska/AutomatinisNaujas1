using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisNaujas1.Page
{
    public class TeidaKamuoliukasZalias8Page5 : BasePage
    {
        public const string PageAddressKamuoliukasZalias8 = "https://www.teida.lt/Sveikatinimui/Koju-sveikatai/Koju-ir-pedu-masazuokliai/REFLEXBALL-8-cm-skersmens-dygliuotas-masazo-kamuoliukas.html?force_sid=s24vri1565rkubs6tatjn869k2";

        public TeidaKamuoliukasZalias8Page5(IWebDriver webdriver) : base(webdriver)
        {
            Driver.Url = PageAddressKamuoliukasZalias8;
        }
        private IWebElement IKrepseli => Driver.FindElement(By.Id("toBasket"));
        private IWebElement BoxText => Driver.FindElement(By.Id("amountToBasket"));
        public void InsertCheckBoxText(string text)
        {
            BoxText.Clear();
            BoxText.SendKeys(text);
        }
        //KAIP PALYGINTI
        public TeidaKamuoliukasZalias8Page5 CheckBoxText(string expectedResutBoxText)
        {
            Assert.AreEgual(expectedResutBoxText, NEZINAU KAIP APRASYTI KAD TAS SKAICIUS YRA TOKIO KOKIO NORIM);
               return this;
        }

        public TeidaKamuoliukasZalias8Page5 ClickIKrepseli()
        {
            IKrepseli.Click();
            return this;
        }
    }
    }

