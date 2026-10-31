using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint3.Task4.V30.Lib;

namespace Tyuiu.KonevIA.Sprint3.Task4.V30.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GivenInterval()
    {
        double expected = Math.Round(2 * (Math.Sin(1) + Math.Sin(2) / 2
            + Math.Sin(3) / 3 + Math.Sin(4) / 4 + Math.Sin(5) / 5), 3);
        Assert.AreEqual(expected, new DataService().Calculate(-5, 5), 1e-12);
    }

    [TestMethod]
    public void ZeroIsSkipped() =>
        Assert.AreEqual(0.0, new DataService().Calculate(0, 0));

    [TestMethod]
    public void IncludesEndpoints() =>
        Assert.AreEqual(1.683, new DataService().Calculate(-1, 1), 1e-12);

    [TestMethod]
    public void SingleNegativeValue() =>
        Assert.AreEqual(0.455, new DataService().Calculate(-2, -2), 1e-12);
}
