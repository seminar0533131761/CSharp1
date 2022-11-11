using Dal.DataObjs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public static class ServiceAccount
    {
        public static void AddAccount(Account newAccount)
        { 

            DataSource.ListAccount.Add(newAccount);
        }
        public static List<Account> GetAll()
        {
            return DataSource.ListAccount;
        }
    }
}
