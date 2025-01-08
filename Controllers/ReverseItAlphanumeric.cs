using Microsoft.AspNetCore.Mvc;
using MiniChallengeFiveToSeven___Endpoints.Service;

namespace MiniChallengeFiveToSeven___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItAlphanumeric : ControllerBase
    {
        readonly ReverseItAlphanumericService _reverseItAlphanumericService;
        public ReverseItAlphanumeric(ReverseItAlphanumericService reverseItAlphanumericService)
        {
            _reverseItAlphanumericService = reverseItAlphanumericService;
        }

        [HttpPost]
        [Route("AddReverseItAlphanumeric/{input}")]
        public string AddReverseItAlphanumeric(string input)
        {
            _reverseItAlphanumericService.AddReverseItAlphanumeric(input);
            return _reverseItAlphanumericService.reverseItAlphanumeric;
        }
    }
}