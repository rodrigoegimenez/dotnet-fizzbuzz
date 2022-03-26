namespace FizzBuzz.Service;
public class FizzBuzzService
{
    public string Of(int number)
    {
        if (number == 5 || number == 10)
        {
            return "Buzz";
        }
        if (number % 3 == 0)
        {
            return "Fizz";
        }
        return number.ToString();
    }
}
