using SeleniumExtras.PageObjects;
using OpenQA.Selenium;


namespace Eskok_autoTest
{
    public class OneTimeTransferOverview
    {
        public OneTimeTransferOverview()
        {
            PageFactory.InitElements(Driver.ChromeDriver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#form > div.buttons > button > span")]
        public IWebElement NextButton { get; set; }
    }
}





