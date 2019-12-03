using SeleniumExtras.PageObjects;
using OpenQA.Selenium;


namespace Eskok_autoTest
{
    public class Menu
    {
        public Menu()
        {
            PageFactory.InitElements(Driver.ChromeDriver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/nav/ul/li[1]/a")]
        public IWebElement MainPage { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/nav/ul/li[2]/a")]
        public IWebElement Transfer { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/nav/ul/li[3]/a")]
        public IWebElement Rachunki { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/nav/ul/li[4]/a")]
        public IWebElement Oszczednosci { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/nav/ul/li[5]/a")]
        public IWebElement Pozyczki { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/nav/ul/li[6]/a")]
        public IWebElement Karty { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/nav/ul/li[7]/a")]
        public IWebElement Ubezpieczenia { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/nav/ul/li[8]/a")]
        public IWebElement Wnioski { get; set; }
    }
}