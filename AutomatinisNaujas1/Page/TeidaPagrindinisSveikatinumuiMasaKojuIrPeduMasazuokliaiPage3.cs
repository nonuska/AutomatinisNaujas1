using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisNaujas1.Page
{
    public class TeidaKojuSveikataPage3 : BasePage
    {
        private const string PageAddressKojuSveikata = "https://www.teida.lt/Sveikatinimui/Koju-sveikatai/";

        public TeidaKojuSveikataPage3(IWebDriver webdriver) : base(webdriver)
        {
            Driver.Url = PageAddressKojuSveikata;
        }

        private IWebElement KojuPeduMasazuolkiai => Driver.FindElement(By.Id("moreSubCat_1"));
        
        //labai ilgai krauna gal koki wait irasyti!!!!!!!!!!
        
        public TeidaKojuSveikataPage3 ClickKojuPeduMasazuolkiai()
        {
            KojuPeduMasazuolkiai.Click();
            return this;
        }
        // arba kitaip

        /*
          KAIP TIKLSIAI NEAISKU
         

        public PageAddressKojuSveikata ClickKojuPeduMasazuolkiai() //KAIP CIA SITA PASIRASYTI
        {
            Actions action = new Actions(driver); //ar cia driver ar sveikatinimui rasyt?
            action.DoubleClick(Keys.LeftControl);
            action.Build().Perform();
            action.Click(KojuPeduMasazuolkiai);
            action.Build().Perform();
            return this;
        }
         */




    }
}
