using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisNaujas1.Page
{
    public class TeidaKamuoliukasGeltonas10Page6 : BasePage
    {
        public const string PageAddressKamuoliukasGeltonas10 = "https://www.teida.lt/Sveikatinimui/Koju-sveikatai/Koju-ir-pedu-masazuokliai/Masazo-kamuoliukas-Sensyball-10.html?force_sid=s24vri1565rkubs6tatjn869k2";

        public TeidaKamuoliukasGeltonas10Page6(IWebDriver webdriver) : base(webdriver)
        {
            Driver.Url = PageAddressKamuoliukasGeltonas10;
        }
        private IWebElement IKrepseli => Driver.FindElement(By.Id("toBasket"));
        private IWebElement BoxText1 => Driver.FindElement(By.Id("amountToBasket"));
        public void InsertCheckBoxText1(string text)
        {
            BoxText1.Clear();
            BoxText1.SendKeys(text);
        }
        //KAIP PALYGINTI
        public TeidaKamuoliukasGeltonas10Page6 CheckBoxText1(string expectedResutBoxText)
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
