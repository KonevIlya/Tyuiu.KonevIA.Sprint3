using Tyuiu.KonevIA.Sprint3.Task1.V9.Lib;

namespace Tyuiu.KonevIA.Sprint3.Task1.V9;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #3 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #3");
        Line("Тема: Цикл while");
        Line("Задание #1");
        Line("Вариант #9");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Вычислить произведение (300 / (cos(x) + x^k))^k.");
        Line("Использовать цикл while. x = 5, k от 1 до 4.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        int x = 5;
        int startValue = 1;
        int stopValue = 4;
        Line($"x = {x}; k от {startValue} до {stopValue}");
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().GetMultiplySeries(x, startValue, stopValue));
        Console.ReadLine();
    }
}


