using Microsoft.AspNetCore.Mvc;
using MiniChallengeFiveToSeven___Endpoints.Service;

namespace MiniChallengeFiveToSeven___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OddOrEven : ControllerBase
    {
        readonly oddOrEvenService _oddOrEvenService;
        public OddOrEven(oddOrEvenService oddOrEvenService)
        {
            _oddOrEvenService = oddOrEvenService;
        }

        [HttpPost]
        [Route("AddOddOrEven/{number}")]
        public string AddOddOrEven(string number)
        {
            _oddOrEvenService.AddOddOrEven(number);
            return _oddOrEvenService.oddOrEven;
        }
    }
}