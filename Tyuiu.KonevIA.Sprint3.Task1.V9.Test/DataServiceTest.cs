using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint3.Task1.V9.Lib;

namespace Tyuiu.KonevIA.Sprint3.Task1.V9.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GivenSeries()
    {
        double c = Math.Cos(5);
        double expected = (300 / (c + 5)) * Math.Pow(300 / (c + 25), 2)
            * Math.Pow(300 / (c + 125), 3) * Math.Pow(300 / (c + 625), 4);
        Assert.AreEqual(Math.Round(expected, 3), new DataService().GetMultiplySeries(5, 1, 4), 1e-8);
    }

    [TestMethod]
    public void SingleTerm() =>
        Assert.AreEqual(Math.Round(Math.Pow(300 / (Math.Cos(5) + 25), 2), 3),
            new DataService().GetMultiplySeries(5, 2, 2), 1e-10);

    [TestMethod]
    public void ZeroArgument() =>
        Assert.AreEqual(27000000.0, new DataService().GetMultiplySeries(0, 1, 2), 1e-8);
}


