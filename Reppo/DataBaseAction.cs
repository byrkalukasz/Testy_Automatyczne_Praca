using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eskok_autoTest
{
    class DataBaseAction
    {
        public void EditUserToActive(string _userLogin)
        {
            //UPDATE[ESKOK].[USERD] SET USER_ACTIVE = 0, PWD = 'PasswordNotSet' WHERE login like ' + _userLogin + '
        }
        public void AddMoneyToUserAccount(string _accountId)
        {
            //UPDATE ESKOK.ACCOUNT SET BALANCE = 10000000 WHERE ID = 453285
            //UPDATE ESKOK.ACCOUNT SET AVAIL = 10000000 WHERE ID = 453285
            //UPDATE ESKOK.ACCOUNT SET AMOUNT = 10000000 WHERE ID = 453285
        }
    }
}
