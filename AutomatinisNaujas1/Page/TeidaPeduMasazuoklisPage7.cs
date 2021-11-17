using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisNaujas1.Page
{
    public class TeidaPeduMasazuoklisPage7 : BasePage
    { 
      public const string PageAddressPeduMasazuoklis = "https://www.teida.lt/Sveikatinimui/Koju-sveikatai/Koju-ir-pedu-masazuokliai/Thera-band-pedu-masazuoklis.html?force_sid=s24vri1565rkubs6tatjn869k2";

    public TeidaPeduMasazuoklisPage7(IWebDriver webdriver) : base(webdriver)
    {
        Driver.Url = PageAddressPeduMasazuoklis;
    }
        //NEZINAU AR TAIP BET BOXTEXT BET JIS VISUR VIENODAS
    private IWebElement IKrepseli => Driver.FindElement(By.Id("toBasket"));
    private IWebElement BoxText2 => Driver.FindElement(By.Id("amountToBasket"));
    public void InsertCheckBoxText1(string text)
    {
        BoxText2.Clear();
        BoxText2.SendKeys(text);
    }
    //KAIP PALYGINTI
    public TeidaKamuoliukasGeltonas10Page6 CheckBoxText1(string expectedResutBoxText)
    {
        Assert.AreEgual(expectedResutBoxText2, NEZINAU KAIP APRASYTI KAD TAS SKAICIUS YRA TOKIO KOKIO NORIM);
        return this;
    }

    public TeidaPeduMasazuoklisPage7 ClickIKrepseli()
    {
        IKrepseli.Click();
        return this;
    }
}
}
