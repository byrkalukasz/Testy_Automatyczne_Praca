using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Eskok_autoTest
{
    public static class Driver
    {
        public static IWebDriver ChromeDriver { get; set; }
        public static IWebDriver IEDriver { get; set; }
        public static IWebDriver OperaDriver { get; set; }
    }
}
