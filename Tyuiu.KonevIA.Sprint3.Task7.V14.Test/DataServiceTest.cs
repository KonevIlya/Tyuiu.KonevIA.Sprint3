using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KonevIA.Sprint3.Task7.V14.Lib;

namespace Tyuiu.KonevIA.Sprint3.Task7.V14.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GivenTable() =>
        CollectionAssert.AreEqual(new double[]
        {
            -19.62, -17.12, -18.15, -63.13, -24.92, -5,
            -1.46, 1.57, 6.38, 32.78, 225.11
        }, new DataService().GetMassFunction(-5, 5));

    [TestMethod]
    public void SinglePoint() =>
        CollectionAssert.AreEqual(new[] { -5.0 }, new DataService().GetMassFunction(0, 0));

    [TestMethod]
    public void DifferentInterval() =>
        CollectionAssert.AreEqual(new[] { 1.57, 6.38 }, new DataService().GetMassFunction(2, 3));
}
