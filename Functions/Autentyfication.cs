using System;
using System.IO;

namespace Eskok_autoTest
{
    class Autentyfication
    {
        public string GetSmsPassword()
        {
            string tekst, SMSCode = "";
            int index;
            if (File.Exists("D:\\kopia.txt"))
            {
                File.Delete("D:\\kopia.txt");
            }
            File.Copy("C:\\apache-tomcat-6.0.53\\logs\\tomcat6-stdout.2019-11-29.log", "D:\\kopia.txt");
            FileStream test = new FileStream("D:\\kopia.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(test);

            while ((tekst = reader.ReadLine()) != null)
            {
                index = tekst.LastIndexOf("SMS:");
                if (index >= 0)
                {
                    SMSCode = tekst.Substring(index + 4);
                }
            }
            return SMSCode;
        }
        public string ValidUserLoginSelect()
        {
            string[] ValidUserLoginTable = { "0655175779" };
            string ValidUserLogin;
            int UserNumber;
            Random UserRandom = new Random();
            UserNumber = UserRandom.Next(ValidUserLoginTable.Length);
            ValidUserLogin = ValidUserLoginTable[UserNumber];
            return ValidUserLogin;
        }
        public string InvalidUserLoginSelect()
        {
            string[] InvalidUserLoginTable = { "0425385987", "065" };
            string InvalidUserLogin;
            int UserNumber;
            Random UserRandom = new Random();
            UserNumber = UserRandom.Next(InvalidUserLoginTable.Length);
            InvalidUserLogin = InvalidUserLoginTable[UserNumber];
            return InvalidUserLogin;
        }
    }
}
