namespace FizzBuzz.Service;
public class FizzBuzzService
{
    public string Of(int number)
    {
        if (IsFizz(number) && IsBuzz(number))
        {
            return "FizzBuzz";
        }
        if (IsBuzz(number))
        {
            return "Buzz";
        }
        if (IsFizz(number))
        {
            return "Fizz";
        }
        return number.ToString();
    }

    private bool IsFizz(int number) => number % 3 == 0;
    private bool IsBuzz(int number) => number % 5 == 0;

}
