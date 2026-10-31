using Tyuiu.KonevIA.Sprint3.Task0.V22.Lib;

namespace Tyuiu.KonevIA.Sprint3.Task0.V22;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #3 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #3");
        Line("Тема: Цикл for");
        Line("Задание #0");
        Line("Вариант #22");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Вычислить произведение (a^k + 4) * cos(a) при k от 1 до 8.");
        Line("Использовать цикл for. a = 0,25.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        double a = 0.25;
        int startValue = 1;
        int stopValue = 8;
        Line($"a = {a}; k от {startValue} до {stopValue}");
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().GetMultiplySeries(a, startValue, stopValue));
        Console.ReadLine();
    }
}
