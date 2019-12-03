using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace Eskok_autoTest
{
    class MainPage
    {
        public MainPage()
        {
            PageFactory.InitElements(Driver.ChromeDriver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/section[3]/table/tbody/tr[1]/td[3]")]
        public IWebElement LogUotButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/section[3]/table/tbody/tr[1]/td[3]")]
        public IWebElement DayLimit { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/section[3]/table/tbody/tr[2]/td[3]")]
        public IWebElement MonthLimit { get; set; }
    }
}
