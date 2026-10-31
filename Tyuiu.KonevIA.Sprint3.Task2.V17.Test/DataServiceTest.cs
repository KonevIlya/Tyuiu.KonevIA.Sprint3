using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint3.Task2.V17.Lib;

namespace Tyuiu.KonevIA.Sprint3.Task2.V17.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GivenSeries()
    {
        double expected = Enumerable.Range(1, 10).Select(k =>
            1 / ((Math.Cos(k) + 2) * (Math.Cos(k) + 2))).Sum();
        Assert.AreEqual(Math.Round(expected, 3), new DataService().GetSumSeries(1, 10), 1e-12);
    }

    [TestMethod]
    public void SingleTerm() =>
        Assert.AreEqual(Math.Round(1.0 / 9, 3), new DataService().GetSumSeries(0, 0), 1e-12);

    [TestMethod]
    public void IncludesBothEndpoints()
    {
        double expected = 1 / Math.Pow(Math.Cos(2) + 2, 2)
            + 1 / Math.Pow(Math.Cos(3) + 2, 2);
        Assert.AreEqual(Math.Round(expected, 3), new DataService().GetSumSeries(2, 3), 1e-12);
    }
}

