using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisNaujas1.Page
{
    public class TeidaSveikatinimuiPage2 : BasePage
    {
        public const string PageAddressSveikatinimui = "https://www.teida.lt/Sveikatinimui/"; //SVEIKATINIMUI
        public TeidaSveikatinimuiPage2(IWebDriver webdriver) : base(webdriver)
        {
            Driver.Url = PageAddressSveikatinimui;
        }
        private IWebElement KojuSveikatai => Driver.FindElement(By.Id("moreSubCat_4")); //nezinau ar cia gerai id pasirinkau nes kartais paveiksleli duoda o kartais eilute????
        //gal sitaip rasyt vietoj kojuSveiktai
        //
       // private IWebElement text => Driver.FindElement(By.Id("moreSubCat_4"));
        public TeidaSveikatinimuiPage2 ClickKojuSveikatai()
        {
            KojuSveikatai.Click();
            return this;

        }

        /* KAIP TIKLSIAI NEAISKU
         * 
         
        public PageAddressSveikatinimui ClickKojuSveikatai() //KAIP CIA SITA PASIRASYTI
        {
        Actions action = new Actions(driver); //ar cia driver ar sveikatinimui rasyt?
        action.DoubleClick(Keys.LeftControl);
         action.Build().Perform();
        action.Click(KojuSveikatai);
        action.Build().Perform();
        return this;
        }
         */

        //ASSERT APSIRASYTIkazkaip cia ne taip, gal virsur prie IWebElement rasyt ne kojuSveikatai, o pvz IWebElemnt text
        public CheckboxDemoPage CheckResult()
        {
            Assert.IsTrue(KojuSveikatai.Text.Equals(TextToCheck));
            return this;
        }
    }

    }
