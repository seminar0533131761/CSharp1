using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dal.DataObjs;

namespace BL
{
    public class BLAccount
    {
        public static List<Account> GetAccount()
        {
            return ServiceAccount.GetAll();
        }
        public static void AddAccount(Account newAccount)
        {
            ServiceAccount.AddAccount(newAccount);
        }
    }
}
