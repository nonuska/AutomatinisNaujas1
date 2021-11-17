using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisNaujas1.Page
{
    public class TeidaPagrindinisPage1 : BasePage
    {
        private const string PageAddressTeidaPagrindinis = "https://www.teida.lt/"; //pagrindinis 
      

        private TeidaPagrindinisPage1(IWebDriver webdriver) : base(webdriver)
        {
            
            Driver.Url = "PageAddressTeidaPagrindinis"; 
        }

        private IWebElement Sveikatinimui => Driver.FindElement(By.CssSelector("#leftMen > li.active > div > a")); // SVEIKATINIMUI //nes pagal selektoriu visu tas pati klase


        public TeidaPagrindinisPage1 ClickSveikatinimui()
        {
            Sveikatinimui.Click();
            return this;
        }
        /* ARBA
         * KAIP TIKSLIAI APRASYTI// KAD 2 KART PASPAUDZIU, NORS REALIAI IR SU VIENU CLICK GALIU RASYT
         * 
         public TeidaPagrindinisPage1 ClickSveikatinimui() //KAIP CIA SITA PASIRASYTI
        {
        Actions action = new Actions(driver); //ar cia driver ar sveikatinimui rasyt?
        action.DoubleClick(Keys.LeftControl);
         action.Build().Perform();
        action.Click(Sveikatinimui);
        action.Build().Perform();
        return this;
        }


         */
        //AR CIA REIKIA RASYT ASSERT

    }




}
