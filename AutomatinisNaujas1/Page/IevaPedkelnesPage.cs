using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisNaujas1.Page
{
    public class IevaPedkelnesPage : BasePage
    {
        private const string PageAddress = "https://e-ievapedkelnes.lt/";
        private IWebElement BlauzdinessButton => Driver.FindElement(By.CssSelector(".active"));
        public IevaPedkelnesPage(IWebDriver webdriver) : base(webdriver)
        {
            Driver.Url = PageAddress;
        }
    }


    public IevaPedkelnesPage ClickBlauzdinesButton()
    {
        BlauzdinesButton.Click();
        return this;
    }

    //kitas psl
    public
    private IWebElement BlauzdinesButton  => Driver.FindElement(By.Id("image")); //steven blauzdines
    private IWebElement BlauzdinesJuodosCheck => DriverOptions.FindElement(By.Id("option-value-3486")); //Juodos spalvos blauzdines
    private IWebElement KrepselisButton => Driver.FindElement(By.Id("cart-total")); //krepselis
