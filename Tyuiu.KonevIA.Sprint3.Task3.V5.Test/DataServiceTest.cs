using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint3.Task3.V5.Lib;

namespace Tyuiu.KonevIA.Sprint3.Task3.V5.Test;

[TestClass]
public class DataServiceTest
{
    [DataTestMethod]
    [DataRow("fifa al fall", 'a', '*', "fif* *l f*ll")]
    [DataRow("aaa", 'a', '*', "***")]
    [DataRow("", 'a', '*', "")]
    [DataRow("ABC", 'a', '*', "ABC")]
    [DataRow("test", 't', '!', "!es!")]
    public void ValidReplacement(string value, char replaceable, char replacement, string expected) =>
        Assert.AreEqual(expected, new DataService().ReplaceCharInString(value, replaceable, replacement));
}
