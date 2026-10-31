using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KonevIA.Sprint3.Task1.V9.Lib;

public class DataService : ISprint3Task1V9
{
    public double GetMultiplySeries(int value, int startValue, int stopValue)
    {
        double product = 1;
        int k = startValue;
        while (k <= stopValue)
        {
            product *= Math.Pow(300 / (Math.Cos(value) + Math.Pow(value, k)), k);
            k++;
        }
        return product;
    }
}

