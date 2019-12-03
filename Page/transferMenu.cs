using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace Eskok_autoTest.Page
{
    public class TransferMenu
    {
        public TransferMenu()
        {
            PageFactory.InitElements(Driver.ChromeDriver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/section[1]/ul/li[1]/a")]
        public IWebElement OneTimeTransfer { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/section[1]/ul/li[2]/a")]
        public IWebElement OwnOneTimeTransfer { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/section[1]/ul/li[3]/a")]
        public IWebElement USOneTimeTransfer { get; set; }
    }
}
