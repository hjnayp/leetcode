using JetBrains.Annotations;
using source._0000._35;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test35
{
    [TestMethod]
    [Timeout(1000)]
    public void TestSolution_WhenNumsContainTarget_ShouldReturnIndex()
    {
        Solution solution = new();
        Assert.AreEqual(2, solution.SearchInsert([1, 3, 5, 6], 5));
    }

    [TestMethod]
    [Timeout(1000)]
    public void TestSolution_WhenNumsNotContainTarget_ShouldReturnFirstGreaterElementIndex()
    {
        Solution solution = new();
        Assert.AreEqual(1, solution.SearchInsert([1, 3, 5, 6], 2));
    }

    [TestMethod]
    [Timeout(1000)]
    public void TestSolution_WhenTargetIsGreaterThanTheLastElementInNums_ShouldReturnTheNumsLength()
    {
        Solution solution = new();
        Assert.AreEqual(4, solution.SearchInsert([1, 3, 5, 6], 7));
    }
}