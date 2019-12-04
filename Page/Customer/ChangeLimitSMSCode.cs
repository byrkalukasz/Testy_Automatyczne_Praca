using SeleniumExtras.PageObjects;
using OpenQA.Selenium;


namespace Eskok_autoTest
{
    class ChangeLimitSMSCode
    {
        public ChangeLimitSMSCode()
        {
            PageFactory.InitElements(Driver.ChromeDriver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#keyboard-calculator")]
        public IWebElement SMSPasswordField { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/div/section/form/div[3]/ul/li[2]/button")]
        public IWebElement AkceptButtn { get; set; }
    }
}
