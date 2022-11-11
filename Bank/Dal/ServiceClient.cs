using Dal.DataObjs;

namespace Dal
{
    public static class ServerClient
    {
        public static void AddCostum(Costumer newCostum)
        {

            DataSource.ListCostumer.Add(newCostum);
        }
        public static List<Costumer> GetAll()
        {
            return DataSource.ListCostumer;
        }
    }
}