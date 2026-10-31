using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KonevIA.Sprint3.Task0.V22.Lib;

public class DataService : ISprint3Task0V22
{
    public double GetMultiplySeries(double value, int startValue, int stopValue)
    {
        double product = 1;
        for (int k = startValue; k <= stopValue; k++)
            product *= (Math.Pow(value, k) + 4) * Math.Cos(value);
        return product;
    }
}
