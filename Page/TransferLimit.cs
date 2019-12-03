using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace Eskok_autoTest
{
    class TransferLimit
    {
        public TransferLimit()
        {
            PageFactory.InitElements(Driver.ChromeDriver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/div/section/div/div[2]/table/tbody/tr[1]/td[3]/ul/li/a/span")]
        public IWebElement ChangeDayLimit { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/div/section/div/div[2]/table/tbody/tr[3]/td[3]/ul/li/a/span")]
        public IWebElement ChangeMonthLimit { get; set; }
    }
}
