using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KonevIA.Sprint3.Task6.V13.Lib;

public class DataService : ISprint3Task6V13
{
    public int GetSumTheDivisors(int startValue, int stopValue)
    {
        int sum = 0;
        for (int number = startValue; number <= stopValue; number++)
        {
            for (int divisor = 9; divisor <= number; divisor++)
            {
                if (number % divisor == 0)
                    sum += divisor;
            }
        }
        return sum;
    }
}
