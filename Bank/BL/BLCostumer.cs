
using Dal;
using Dal.DataObjs;
namespace BL

{
    public class BLCostumer
    {
        public static List<Costumer> GetCostumers()
        {
            return ServerClient.GetAll();
        }
        public static void  AddCostumer( Costumer newCostumer)
        {
            ServerClient.AddCostum(newCostumer);
        }
    }
}