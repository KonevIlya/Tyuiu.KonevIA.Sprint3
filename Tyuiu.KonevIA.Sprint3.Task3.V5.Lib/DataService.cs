using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KonevIA.Sprint3.Task3.V5.Lib;

public class DataService : ISprint3Task3V5
{
    public string ReplaceCharInString(string value, char replaceable, char replacement)
    {
        var result = new StringBuilder();
        foreach (char symbol in value)
            result.Append(symbol == replaceable ? replacement : symbol);
        return result.ToString();
    }
}
