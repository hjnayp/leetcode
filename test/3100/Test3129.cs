using JetBrains.Annotations;
using source._3100._3129;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3129
{
    private readonly Solution solution = new();

    [TestMethod]
    public void NormalCase()
    {
        Assert.AreEqual(2, solution.NumberOfStableArrays(1, 1, 2));
        Assert.AreEqual(1, solution.NumberOfStableArrays(1, 2, 1));
        Assert.AreEqual(14, solution.NumberOfStableArrays(3, 3, 2));
    }
}