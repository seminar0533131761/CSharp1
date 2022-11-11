using Dal.DataObjs;
using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UiController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        [HttpGet]
        public List<Costumer> GetAllCostumers()
        {
            return BLCostumer.GetCostumers();
        }
        [HttpGet("{CId}")]
        public Costumer GetCostumers(int CId)
        {
             return BLCostumer.GetCostumers().Where(c=>c.Id==CId).FirstOrDefault();
        }
        [HttpPut]
        public void PutCostumers(Costumer newCostumer) 
        {
            BLCostumer.AddCostumer(newCostumer);
        }
    }
}
