using JetBrains.Annotations;

namespace test.AssertHelpers;

[TestClass]
[TestSubject(typeof(TwoDimensionalArrayAssert))]
public class TwoDimensionalArrayAssert_Test
{
    [TestMethod]
    public void TestTwoDimensionalArray()
    {
        IList<IList<int>> arr1 = [[1, 1], [], [2]];
        IList<IList<int>> arr2 = [[2], [1, 1], []];
        Assert.IsTrue(TwoDimensionalArrayAssert.AreEquivalent(arr1, arr2));

        arr2 = [[1, 1], []];
        Assert.IsFalse(TwoDimensionalArrayAssert.AreEquivalent(arr1, arr2));
    }
}