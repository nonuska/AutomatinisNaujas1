using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisNaujas1.Page
{
    public class TeidaPage1 : BasePage
    {
       
            private const string PageAddress = "https://www.teida.lt/Sveikatinimui/";
        private SelectElement TeidaPage => new SelectElement(Driver.FindElement(By.Id("moreSubCat_4"))); //koju sveikatai
    }
}
