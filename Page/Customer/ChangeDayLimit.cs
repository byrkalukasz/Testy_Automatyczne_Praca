using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace Eskok_autoTest
{
    class ChangeDayLimit
    {
        public ChangeDayLimit()
        {
            PageFactory.InitElements(Driver.ChromeDriver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/div/section/form/div[2]/div[2]/div/div/table/tbody/tr[3]/td[2]/input")]
        public IWebElement NewLimitTextField { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/div/section/form/div[2]/div[2]/div/div/table/tbody/tr[1]/td[2]")]
        public IWebElement MonthLimit { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/div/section/form/div[2]/div[2]/div/div/table/tbody/tr[2]/td[2]")]
        public IWebElement DayLimit { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/div/section/form/div[3]/ul/li[2]/button/span/span")]
        public IWebElement NextButton { get; set; }

    }
}
