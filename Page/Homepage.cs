using SeleniumExtras.PageObjects;
using OpenQA.Selenium;


namespace Eskok_autoTest
{
    public class Homepage
    {
        public Homepage()
        {
            PageFactory.InitElements(Driver.ChromeDriver, this);
        }
        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement LoginField { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".actions > ul:nth-child(1) > li:nth-child(2) > a:nth-child(1)")]
        public IWebElement NextButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/section/section/div[2]/div[1]/form/div[3]/ul/li[2]/a")]
        public IWebElement BackButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/section/section/div[2]/div[1]/form/div[3]/ul/li[1]/a")]
        public IWebElement ActiveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/section/section/div[2]/div[2]/ul/li[1]/a")]
        public IWebElement UnlockButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/section/section/div[1]/div[1]/form/div[3]/ul/li[3]/a")]
        public IWebElement LoginButton { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section/section/div[1]/div[1]/form/div[3]/ul/li[3]/a")]
        public IWebElement ErrorBox { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div/div/div/section/form/div/button")]
        public IWebElement FirstAlertButton { get; set; }
    }
}




