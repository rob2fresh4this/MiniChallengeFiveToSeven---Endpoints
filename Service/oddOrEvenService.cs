// create an endpoint that displays if a number entered is odd or even.
namespace MiniChallengeFiveToSeven___Endpoints.Service
{
    public class oddOrEvenService
    {
        public string oddOrEven;
        public oddOrEvenService()
        {
            oddOrEven = "Nothing to display!";
        }

        public void AddOddOrEven(string number)
        {
            int convertNumber;

            bool isValied = int.TryParse(number, out convertNumber);

            switch(isValied){
                case true:
                    if (convertNumber % 2 == 0)
                    {
                        oddOrEven = "The number " + convertNumber + " is even.";
                    }
                    else
                    {
                        oddOrEven = "The number " + convertNumber + " is odd.";
                    }
                    break;
                case false:
                    oddOrEven = "Please enter a valid number.";
                    break;
            }
        }
    }
}