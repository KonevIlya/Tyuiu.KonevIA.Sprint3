using Tyuiu.KonevIA.Sprint3.Task5.V23.Lib;

namespace Tyuiu.KonevIA.Sprint3.Task5.V23;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #3 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #3");
        Line("Тема: Вложенные циклы");
        Line("Задание #5");
        Line("Вариант #23");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Вычислить двойную сумму (x^k + 2) * cos(k)");
        Line("при i от 1 до 3, k от 1 до 10, x = 2.");
        Line("Использовать вложенные циклы. Округлить итог до 3 знаков.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        int x = 2;
        Line("x = 2; i = 1..3; k = 1..10");
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().GetSumSumSeries(x, 1, 1, 3, 10));
        Console.ReadLine();
    }
}
