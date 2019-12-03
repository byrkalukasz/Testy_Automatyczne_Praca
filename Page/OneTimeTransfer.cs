using SeleniumExtras.PageObjects;
using OpenQA.Selenium;


namespace Eskok_autoTest
{
    public class OneTimeTransfer
    {
        public OneTimeTransfer()
        {
            PageFactory.InitElements(Driver.ChromeDriver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/section[2]/form/div[2]/button")]
        public IWebElement AnavableMoney { get; set; }
        [FindsBy(How = How.Name, Using = "oneTimeTransferSubform.transfer.amount")]
        public IWebElement AmmountField { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/section[2]/form/table[2]/tbody[1]/tr[1]/td/input")]
        public IWebElement IBANField { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/section[2]/form/table[2]/tbody[1]/tr[2]/td/textarea")]
        public IWebElement Odbioca { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/section[2]/form/table[2]/tbody[4]/tr[1]/td/textarea")]
        public IWebElement Szczegoly { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/section[1]/section[2]/div[2]/section[2]/form/div[2]/button/span")]
        public IWebElement NextButton { get; set; }






    }


}



