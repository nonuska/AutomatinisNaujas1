using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisNaujas1.Page
{
    public class TeidaPagrindinisSveikatinimuiMasaKojuIrPeduMasazuolkliaiPage41 : BasePage

    {
        public const string PageAddressKojuIrPeduMasazuolkliai = "https://www.teida.lt/Sveikatinimui/Koju-sveikatai/Koju-ir-pedu-masazuokliai/";
        public TeidaPagrindinisSveikatinimuiMasaKojuIrPeduMasazuolkliaiPage41(IWebDriver webdriver) : base(webdriver)
        {
            Driver.Url = PageAddressKojuIrPeduMasazuolkliai;
        }

        private IWebElement KamuoliukasGeltonas10 => Driver.FindElement(By.CssSelector("#prodList > ul:nth-child(3) > li:nth-child(1) > a > span.prodPav"));
        private IWebElement KamuoliukasZalias8 => Driver.FindElement(By.CssSelector("#prodList > ul:nth-child(1) > li:nth-child(3) > a > span.prodPav"));
        private IWebElement PeduMasazuoklis => Driver.FindElement(By.CssSelector("#prodList > ul:nth-child(7) > li:nth-child(1) > a > span.prodPav"));

        public TeidaPagrindinisSveikatinimuiMasaKojuIrPeduMasazuolkliaiPage41 ClickKamuoliukasGeltonas10()

        {
            KamuoliukasGeltonas10.Click();
            return this;

        }


        public TeidaPagrindinisSveikatinimuiMasaKojuIrPeduMasazuolkliaiPage41 ClickKamuoliukasZalias8()
        {
            KamuoliukasZalias8.Click();
            return this;
        }

        public TeidaPagrindinisSveikatinimuiMasaKojuIrPeduMasazuolkliaiPage41 ClickPeduMasazuoklis()
        {
            PeduMasazuoklis.Click();
            return this;
        }

        //ASSERT KAIP APSIRASYTI
    }

}

