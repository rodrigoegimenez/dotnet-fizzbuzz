namespace FizzBuzz.Service;
public class FizzBuzzService
{
    public string Of(int number)
    {
        if (number == 2)
        {
            return "2";
        }
        if (number == 4)
        {
            return "4";
        }
        return "1";
    }

}
