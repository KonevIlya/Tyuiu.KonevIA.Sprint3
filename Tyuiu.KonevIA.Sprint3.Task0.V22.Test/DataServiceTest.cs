using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint3.Task0.V22.Lib;

namespace Tyuiu.KonevIA.Sprint3.Task0.V22.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GivenSeries()
    {
        Assert.AreEqual(55217.446, new DataService().GetMultiplySeries(0.25, 1, 8), 1e-8);
    }

    [TestMethod]
    public void ZeroArgument() =>
        Assert.AreEqual(65536.0, new DataService().GetMultiplySeries(0, 1, 8), 1e-8);

    [TestMethod]
    public void SingleTerm() =>
        Assert.AreEqual(Math.Round(4.0625 * Math.Cos(0.25), 3),
            new DataService().GetMultiplySeries(0.25, 2, 2), 1e-12);
}

