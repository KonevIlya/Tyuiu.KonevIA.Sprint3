using Tyuiu.KonevIA.Sprint3.Task6.V13.Lib;

namespace Tyuiu.KonevIA.Sprint3.Task6.V13;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #3 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #3");
        Line("Тема: Обработка целочисленной информации");
        Line("Задание #6");
        Line("Вариант #13");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Для целых чисел от 8 до 17 включительно найти");
        Line("сумму всех их положительных делителей больше 8.");

        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        int startValue = 8;
        int stopValue = 17;
        Line($"Отрезок: [{startValue}, {stopValue}], делители > 8");
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().GetSumTheDivisors(startValue, stopValue));
        Console.ReadLine();
    }
}

