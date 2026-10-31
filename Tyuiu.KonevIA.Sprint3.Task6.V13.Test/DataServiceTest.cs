using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint3.Task6.V13.Lib;

namespace Tyuiu.KonevIA.Sprint3.Task6.V13.Test;

[TestClass]
public class DataServiceTest
{
    [DataTestMethod]
    [DataRow(8, 17, 117)]
    [DataRow(8, 8, 0)]
    [DataRow(9, 9, 9)]
    [DataRow(18, 18, 27)]
    [DataRow(1, 8, 0)]
    public void ValidDivisorSum(int startValue, int stopValue, int expected) =>
        Assert.AreEqual(expected, new DataService().GetSumTheDivisors(startValue, stopValue));
}
