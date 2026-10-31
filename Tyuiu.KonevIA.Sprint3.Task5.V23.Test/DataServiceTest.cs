using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint3.Task5.V23.Lib;

namespace Tyuiu.KonevIA.Sprint3.Task5.V23.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GivenSeries()
    {
        double expected = Math.Round(3 * Enumerable.Range(1, 10)
            .Sum(k => (Math.Pow(2, k) + 2) * Math.Cos(k)), 3);
        Assert.AreEqual(expected, new DataService().GetSumSumSeries(2, 1, 1, 3, 10), 1e-9);
    }

    [TestMethod]
    public void SingleTerm() =>
        Assert.AreEqual(Math.Round(4 * Math.Cos(1), 3),
            new DataService().GetSumSumSeries(2, 1, 1, 1, 1), 1e-12);

    [TestMethod]
    public void DifferentBounds()
    {
        double expected = Math.Round(2 * (6 * Math.Cos(2) + 10 * Math.Cos(3)), 3);
        Assert.AreEqual(expected, new DataService().GetSumSumSeries(2, 2, 2, 3, 3), 1e-12);
    }
}
