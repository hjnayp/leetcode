using JetBrains.Annotations;
using source._0600;

namespace test._0600;

[TestClass]
[TestSubject(typeof(Solution))]
public class Teset600
{
    private readonly Solution solution = new();

    [TestMethod]
    public void NormalCase()
    {
        Assert.AreEqual(5, solution.FindIntegers(5));
        Assert.AreEqual(2, solution.FindIntegers(1));
        Assert.AreEqual(3, solution.FindIntegers(2));
    }
}