using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisNaujas1.Page
{
    public class TeidaPage : BasePage
    {
        private const string PageAddress = "https://www.teida.lt/"; //pagrindinis psl nueinam i sveikatinima
        private SelectElement TeidaPage => new SelectElement(Driver.FindElement(By.CssSelector(".cat_title")));

    }
}
