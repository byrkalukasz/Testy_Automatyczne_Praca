using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace Eskok_autoTest
{
    class ChangeMonthlyLimit
    {
        public ChangeMonthlyLimit()
        {
            PageFactory.InitElements(Driver.ChromeDriver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/div/section/form/div[2]/div[2]/div/div/table/tbody/tr[1]/td[2]")]
        public IWebElement MontlyLimit { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/div/section/form/div[2]/div[2]/div/div/table/tbody/tr[2]/td[2]/input")]
        public IWebElement NewMonthLimit { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/div/section/form/div[3]/ul/li[2]/button")]
        public IWebElement NextButton { get; set; }

    }
}
