using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisNaujas1.Page
{
   public class TeidaKrepselisPage8 : BasePage
    {
        //GALI NETIKTI ADRESAS NES NESU PRISIREGISTRAVUS
       public const string PageAddressKrepselis = "https://www.teida.lt/Krepselis/?force_sid=l9el974mvphvdurnahqib42386";

        private const string ResultText = "Iš viso: ";
        public TeidaKrepselisPage8(IWebDriver webdriver) : base(webdriver)
            {
                Driver.Url = PageAddressKrepselis;
            }
        private IWebElement KamuoliukasGeltonas10 => Driver.FindElement(By.Id(""));
        private IWebElement PeduMasazuolkis => Driver.FindElement(By.Id(""));
        private IWebElement PeduMasazuoklis => Driver.FindElement(By.Id(""));

        private IWebElement KamuoliukasGeltonas10Minus => Driver.FindElement(By.Id("qtyMinus_9decf050242dc18ca6f107d714d3d44c"));
        private IWebElement KamuoliukasGeltonas10Plius => Driver.FindElement(By.Id("qtyPlus_9decf050242dc18ca6f107d714d3d44c"));
        private IWebElement KamuoliukasGeltonas10Kiekis => Driver.FindElement(By.Id("am_9decf050242dc18ca6f107d714d3d44c"));

        private IWebElement KamuoliukasZalias8Minus => Driver.FindElement(By.Id("qtyMinus_7f21cb34da39d803e0ca190f151d07a6"));
        private IWebElement KamuoliukasZalias8Plius => Driver.FindElement(By.Id("qtyPlus_7f21cb34da39d803e0ca190f151d07a6"));
        private IWebElement KamuoliukasZalias8Kiekis => Driver.FindElement(By.Id("am_7f21cb34da39d803e0ca190f151d07a6"));

        private IWebElement PeduMasazuoklisMinus => Driver.FindElement(By.Id("qtyMinus_53836bdfc001a3224afae04ad49aaaa2"));
        private IWebElement PeduMasazuoklisPlius => Driver.FindElement(By.Id("qtyPlus_53836bdfc001a3224afae04ad49aaaa2"));
        private IWebElement PeduMasazuoklisKiekis => Driver.FindElement(By.Id("am_53836bdfc001a3224afae04ad49aaaa2"));

        private IWebElement ButtonSalinti => Driver.FindElement(By.Id("basketRemove"));

    }private IWebElement SumaText => Driver.FindElement(By.CssSelector(".blueLight")); //cia rasysim teksta is viso 
}
