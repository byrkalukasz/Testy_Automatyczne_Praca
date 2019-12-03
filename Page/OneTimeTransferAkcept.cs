using SeleniumExtras.PageObjects;
using OpenQA.Selenium;


namespace Eskok_autoTest
{
    public class OneTimeTransferAkcept
    {
        public OneTimeTransferAkcept()
        {
            PageFactory.InitElements(Driver.ChromeDriver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#keyboard-calculator")]
        public IWebElement PasswordImput { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/section/form/div[3]/button/span")]
        public IWebElement AkceptButton{ get; set; }

    }
}





