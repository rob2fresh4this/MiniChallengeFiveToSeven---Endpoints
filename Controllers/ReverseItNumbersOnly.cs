using Microsoft.AspNetCore.Mvc;
using MiniChallengeFiveToSeven___Endpoints.Service;

namespace MiniChallengeFiveToSeven___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItNumbersOnly : ControllerBase
    {
        readonly ReverseItNumbersOnlyService _reverseItNumbersOnlyService;
        public ReverseItNumbersOnly(ReverseItNumbersOnlyService reverseItNumbersOnlyService)
        {
            _reverseItNumbersOnlyService = reverseItNumbersOnlyService;
        }

        [HttpPost]
        [Route("AddReverseItNumbersOnly/{input1}")]
        public string AddReverseItNumbersOnly(string input1)
        {
            _reverseItNumbersOnlyService.AddReverseItNumbersOnly(input1);
            return _reverseItNumbersOnlyService.reverseItNumbersOnly;
        }
    }
}