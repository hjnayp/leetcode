using JetBrains.Annotations;
using source._0000._50;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test50
{
    private readonly Solution _solution = new();
    private const double Tolerance = 1e-5;

    [TestMethod]
    public void Normal_Case()
    {
        Assert.AreEqual(1024d, _solution.MyPow(2d, 10), Tolerance);
        Assert.AreEqual(9.26100, _solution.MyPow(2.1, 3), Tolerance);
    }

    [TestMethod]
    public void Negative_Pow()
    {
        Assert.AreEqual(0.25000, _solution.MyPow(2d, -2), Tolerance);
    }

    [TestMethod]
    public void Min_Int32_Pow()
    {
        Assert.AreEqual(0d, _solution.MyPow(2d, -2147483648), Tolerance);
    }

    [TestMethod]
    public void Zero_Pow()
    {
        Assert.AreEqual(1d, _solution.MyPow(2d, 0), Tolerance);
    }
}