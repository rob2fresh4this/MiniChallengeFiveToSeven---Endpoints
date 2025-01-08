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
        char[] reversedArray = new char[inputArray2.Length];
        for (int i = 0; i < inputArray2.Length; i++)
        {
            reversedArray[i] = inputArray2[inputArray2.Length - 1 - i];
        }
        reverseItNumbersOnly = "You entered " + input1 + " reversed is " + new string(reversedArray);
    }
    else
    {
        reverseItNumbersOnly = "Please enter a valid number.";
    }
}

    }
}