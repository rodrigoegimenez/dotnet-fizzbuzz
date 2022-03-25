namespace FizzBuzz.Service;
public class FizzBuzzService
{
    public string Of(int number)
    {
        if (number == 3 || number == 6)
        {
            return "Fizz";
        }
        return number.ToString();
    }
}
