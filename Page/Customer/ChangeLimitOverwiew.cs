using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace Eskok_autoTest
{
    class ChangeLimitOverwiew
    {
        public ChangeLimitOverwiew()
        {
            PageFactory.InitElements(Driver.ChromeDriver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/div/section/form/div[3]/ul/li[3]/button/span")]
        public IWebElement AkceptButton { get; set; }
    }
}
