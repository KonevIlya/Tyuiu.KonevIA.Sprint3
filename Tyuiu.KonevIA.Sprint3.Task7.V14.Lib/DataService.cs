using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KonevIA.Sprint3.Task7.V14.Lib;

public class DataService : ISprint3Task7V14
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        var values = new double[stopValue - startValue + 1];
        for (int i = 0; i < values.Length; i++)
        {
            int x = startValue + i;
            double denominator = Math.Sin(x) + 1;
            values[i] = denominator == 0
                ? 0
                : Math.Round(2 * x - 4 + (2.0 * x - 1) / denominator, 2);
        }
        return values;
    }
}
