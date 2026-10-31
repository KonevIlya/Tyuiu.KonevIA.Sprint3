using Tyuiu.KonevIA.Sprint3.Task7.V14.Lib;

namespace Tyuiu.KonevIA.Sprint3.Task7.V14;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #3 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #3");
        Line("Тема: Итоговые проекты по спринту");
        Line("Задание #7");
        Line("Вариант #14");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("F(x) = 2*x - 4 + (2*x - 1) / (sin(x) + 1).");
        Line("Табулировать на [-5; 5] с шагом 1, записать значения в массив.");
        Line("При делении на ноль вернуть 0. Округлить до двух знаков.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        int startValue = -5;
        int stopValue = 5;
        Line($"Отрезок: [{startValue}; {stopValue}], шаг: 1");
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        double[] values = new DataService().GetMassFunction(startValue, stopValue);
        Console.WriteLine("{0,8} | {1,12}", "X", "F(X)");
        Console.WriteLine(new string('-', 24));
        for (int i = 0; i < values.Length; i++)
            Console.WriteLine("{0,8} | {1,12:F2}", startValue + i, values[i]);
        Console.ReadLine();
    }
}
