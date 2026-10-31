using Tyuiu.KonevIA.Sprint3.Task4.V30.Lib;

namespace Tyuiu.KonevIA.Sprint3.Task4.V30;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #3 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #3");
        Line("Тема: Операторы continue и break в циклах");
        Line("Задание #4");
        Line("Вариант #30");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Вычислить сумму sin(x)/x для целых x от -5 до 5.");
        Line("При x = 0 пропустить значение. Округлить итог до 3 знаков.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");

        int startValue = -5;
        int stopValue = 5;
        Line($"x от {startValue} до {stopValue}");
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().Calculate(startValue, stopValue));
        Console.ReadLine();
    }
}




