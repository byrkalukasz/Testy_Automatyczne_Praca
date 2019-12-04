using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace Eskok_autoTest
{ 
    class ChangeMontlyLimitAccept
    {
        public ChangeMontlyLimitAccept()
        {
            PageFactory.InitElements(Driver.ChromeDriver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/div/section/form/div[2]/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[1]/div/input")]
        public IWebElement SMSPasswordField { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/div/section/form/div[3]/ul/li[2]/button")]
        public IWebElement AcceptButton { get; set; }
    }
}
