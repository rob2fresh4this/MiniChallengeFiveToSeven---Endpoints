// create an endpoint that accepts multiple inputs.  Output should be a story based on those values.
namespace MiniChallengeFiveToSeven___Endpoints.Service
{
    public class MadLibService
    {


        public string madLib;
        public MadLibService()
        {
            madLib = "Nothing to display!";
        }

        public void AddMadLib(string animal, string place, string object1, string exclamation)
        {
            madLib = "";
            madLib += " One day, a " + animal + " decided to visit a " + place + ". Along the way, it found a " + object1 + " and yelled, " + exclamation + "!";
        }
    }
}