using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace Eskok_autoTest
{ 
    class NewMontlyLimitAccept
    {
        public NewMontlyLimitAccept()
        {
            PageFactory.InitElements(Driver.ChromeDriver, this);
        }

    }
}
