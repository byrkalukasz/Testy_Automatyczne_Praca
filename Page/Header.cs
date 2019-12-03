using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace Eskok_autoTest
{
    class Header
    {
        public Header()
        {
            PageFactory.InitElements(Driver.ChromeDriver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/header/ul/li[4]/a")]
        public IWebElement LogoutButton { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/nav/ul/li[2]/a")]
        public IWebElement OneTimeTransfer { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/header/ul/li[2]/a/span")]
        public IWebElement Settings { get; set; }
    }
}
