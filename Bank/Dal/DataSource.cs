using Dal.DataObjs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public static class DataSource
    {
        public static List<Costumer> ListCostumer  { get; set; } = new List<Costumer>();
        public static List<Account> ListAccount { get; set; } = new List<Account>();

        public static void InitListPerson()
        {

        }
    }
}
