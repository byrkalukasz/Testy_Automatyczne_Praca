using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Eskok_autoTest
{
    class Action
    {

        public Action()
        { }
        public static void InitDriverOnMainPage()
        {
            Driver.ChromeDriver = new ChromeDriver();
            Config config = new Config();
        }
        public string GetValidIBANNumber()
        {
            string ValidIBAN = null;
            int IBANNumber;
            string[] ValidIBANTable = { "55150022664335530029997443", "90938710421333636966174857", "55109024867802158707229639", "73914510370015485197942111" };
            Random IBANRandom = new Random();
            IBANNumber = IBANRandom.Next(ValidIBANTable.Length);
            ValidIBAN = ValidIBANTable[IBANNumber];
            return ValidIBAN;
        }
        public string GetValidTrasferAmmount(string AnavableMoney, string DayLimit, string MonthlyLimit)
        {
            double transferammount;
            string Helper;
            double anavableMoney, dayLimit, monthlyLimit;
            int table1, table2;
           // anavableMoney =Convert.ToDouble(AnavableMoney);
            int[] FirstNumberAmmountTable = new int[] { 1,2,3};
            int[] SecondNubmerAmmountTable = new int[] { 00, 01, 02, 03, 55, 22, 44, 1, 33, 66, 88, 22, 44, 54, 77, 22, 44, 88, 99, 22, 75 };
            Random randomNumber = new Random();
            table1 = randomNumber.Next(FirstNumberAmmountTable.Length);
            table2 = randomNumber.Next(SecondNubmerAmmountTable.Length);
            Helper = FirstNumberAmmountTable[table1] + "," + SecondNubmerAmmountTable[table2];

            return Helper;
        }
        public string GetRandomFromRange(string _first, string _last)
        {
            string RandomDigit;
            double First, Last;
            First = Convert.ToDouble(_first);
            Last = Convert.ToDouble(_last);
            Random random = new Random();
            double rInt = random.NextDouble() * First;
            RandomDigit = Convert.ToString(rInt);
            return RandomDigit;
        }
    }
}
