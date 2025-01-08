// endpoint that accepts a sequence of numbers and letters then reverses them.
namespace MiniChallengeFiveToSeven___Endpoints.Service
{
    public class ReverseItAlphanumericService
    {
        public string reverseItAlphanumeric;

        public ReverseItAlphanumericService()
        {
            reverseItAlphanumeric = "Nothing to display!";
        }

        public void AddReverseItAlphanumeric(string input)
        {
            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            reverseItAlphanumeric = "You entered " + input + " reversed is " + new string(inputArray);
        }
    }
}