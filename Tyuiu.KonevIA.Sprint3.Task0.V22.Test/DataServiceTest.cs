using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint3.Task0.V22.Lib;

namespace Tyuiu.KonevIA.Sprint3.Task0.V22.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GivenSeries()
    {
        double expected = (4.25 * 4.0625 * 4.015625 * 4.00390625
            * 4.0009765625 * 4.000244140625 * 4.00006103515625 * 4.0000152587890625)
            * Math.Pow(Math.Cos(0.25), 8);
        Assert.AreEqual(expected, new DataService().GetMultiplySeries(0.25, 1, 8), 1e-8);
    }

    [TestMethod]
    public void ZeroArgument() =>
        Assert.AreEqual(65536.0, new DataService().GetMultiplySeries(0, 1, 8), 1e-8);

    [TestMethod]
    public void SingleTerm() =>
        Assert.AreEqual(4.0625 * Math.Cos(0.25),
            new DataService().GetMultiplySeries(0.25, 2, 2), 1e-12);
}
