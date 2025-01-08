using Microsoft.AspNetCore.Mvc;
using MiniChallengeFiveToSeven___Endpoints.Service;

namespace MiniChallengeFiveToSeven___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadLib : ControllerBase
    {
        // string adjective, string animal, string place, string object1, string exclamation
        private readonly MadLibService _madLibService;
        public MadLib(MadLibService madLibService)
        {
            _madLibService = madLibService;
        }

        [HttpPost]
        [Route("AddMadLib/{animal}/{place}/{object1}/{exclamation}")]
        public string AddMadLib(string animal, string place, string object1, string exclamation)
        {
            _madLibService.AddMadLib(animal, place, object1, exclamation);
            return _madLibService.madLib;
        }
    }
}