using JetBrains.Annotations;
using source._2500._2516;

namespace test._2500;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2516
{
    [TestMethod]
    [Timeout(1000)]
    public void TestSolution()
    {
        var solution = new Solution();
        Assert.AreEqual(3, solution.TakeCharacters("cbbac", 1));
        Assert.AreEqual(3, solution.TakeCharacters("bcca", 1));
        Assert.AreEqual(3, solution.TakeCharacters("abc", 1));
        Assert.AreEqual(3, solution.TakeCharacters("acba", 1));
        Assert.AreEqual(8, solution.TakeCharacters("aabaaaacaabc", 2));
    }

    [TestMethod]
    [Timeout(1000)]
    public void TestSolution_WhenKIsZero_ShouldReturnZero()
    {
        var solution = new Solution();
        Assert.AreEqual(0, solution.TakeCharacters("a", 0));
    }

    [TestMethod]
    [Timeout(1000)]
    public void TestSolution_WhenTheStringLengthIsNotEnough_ShouldReturnMinusOne()
    {
        var solution = new Solution();
        Assert.AreEqual(-1, solution.TakeCharacters("a", 2));
    }

    [TestMethod]
    [Timeout(1000)]
    public void TestSolution_WhenCanNotPickKCharacters_ShouldReturnMinusOne()
    {
        var solution = new Solution();
        Assert.AreEqual(-1, solution.TakeCharacters("abababab", 2));
    }
}