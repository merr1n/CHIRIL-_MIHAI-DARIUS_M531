using CHIRILĂ_MIHAI_DARIUS_M531.Models;
using CHIRILĂ_MIHAI_DARIUS_M531.Services;
using Microsoft.AspNetCore.Mvc;

namespace CHIRILĂ_MIHAI_DARIUS_M531.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class BankServiceController : ControllerBase
    {
        [HttpGet(Name = "Get Bank Clients")]
        public IEnumerable<Client> Get(Guid idBanca)
        {
            Banca banca = _banciRepository.Find(b => b.Id == idBanca);
            IBankService bankService = new BankService();
            bankService.DisplayClients(banca);
        }
    }
}
