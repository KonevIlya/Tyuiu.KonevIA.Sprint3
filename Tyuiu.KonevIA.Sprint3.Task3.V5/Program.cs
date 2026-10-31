using Tyuiu.KonevIA.Sprint3.Task3.V5.Lib;

namespace Tyuiu.KonevIA.Sprint3.Task3.V5;

internal class Program
{
    private static void Main()
    {
        Console.Title = "Спринт #3 | Выполнил: Конев И. А. | НТм-25-1";
        void Line(string text = "") => Console.WriteLine("* " + text.PadRight(71) + " *");
        string border = new('*', 75);
        Console.WriteLine(border);
        Line("Спринт #3");
        Line("Тема: Цикл foreach");
        Line("Задание #3");
        Line("Вариант #5");
        Line("Выполнил: Конев Илья Андреевич | НТм-25-1");
        Console.WriteLine(border);
        Line("УСЛОВИЕ:");
        Line("Используя foreach, заменить буквы a на * в строке fifa al fall.");
        Console.WriteLine(border);
        Line("ИСХОДНЫЕ ДАННЫЕ:");
        string value = "fifa al fall";
        Line(value);
        Console.WriteLine(border);
        Line("РЕЗУЛЬТАТ:");
        Console.WriteLine(border);
        Console.WriteLine(new DataService().ReplaceCharInString(value, 'a', '*'));
        Console.ReadLine();
    }
}
