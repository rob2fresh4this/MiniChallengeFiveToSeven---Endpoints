//  endpoint that accepts a sequence of only numbers and reverses them. Be sure to display the original characters before the reversed
namespace MiniChallengeFiveToSeven___Endpoints.Service
{
    public class ReverseItNumbersOnlyService
    {
        public string reverseItNumbersOnly;
        public ReverseItNumbersOnlyService()
        {
            reverseItNumbersOnly = "Nothing to display!";
        }

        public void AddReverseItNumbersOnly(string input1)
        {
            int convertNumber2;
            bool isValied2 = int.TryParse(input1, out convertNumber2);
            if (isValied2)
            {
                char[] inputArray2 = input1.ToCharArray();
                Array.Reverse(inputArray2);
                reverseItNumbersOnly = "You entered " + input1 + " reversed is " + new string(inputArray2);
            }
            else
            {
                reverseItNumbersOnly = "Please enter a valid number.";
            }
        }
    }
}