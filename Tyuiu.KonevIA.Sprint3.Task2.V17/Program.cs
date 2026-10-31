using Tyuiu.KonevIA.Sprint3.Task2.V17.Lib;

namespace Tyuiu.KonevIA.Sprint3.Task2.V17;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #3 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #3");
        Line("Тема: Цикл do-while");
        Line("Задание #2");
        Line("Вариант #17");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Вычислить сумму (1 / (cos(k) + 2))^2 при k от 1 до 10.");
        Line("Использовать цикл do-while.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");

        int startValue = 1;
        int stopValue = 10;
        Line($"k от {startValue} до {stopValue}");
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().GetSumSeries(startValue, stopValue));
        Console.ReadLine();
    }
}



