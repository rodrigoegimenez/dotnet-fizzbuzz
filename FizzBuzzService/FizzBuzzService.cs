namespace FizzBuzz.Service;
public class FizzBuzzService
{
    public string Of(int number)
    {
        if (number == 3)
        {
            return "Fizz";
        }
        return number.ToString();
    }
}
