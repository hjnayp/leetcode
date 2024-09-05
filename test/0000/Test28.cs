using JetBrains.Annotations;
using source._0000._28;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test28
{
    [TestMethod]
    [Timeout(1000)]
    public void TestSolution()
    {
        var solution = new Solution();

        string haystack = "sadbutsad";
        string needle = "sad";
        int expected = 0;
        Assert.AreEqual(expected, solution.StrStr(haystack, needle));

        needle = "but";
        expected = 3;
        Assert.AreEqual(expected, solution.StrStr(haystack, needle));

        haystack = "aaaaa";
        needle = "bba";
        expected = -1;
        Assert.AreEqual(expected, solution.StrStr(haystack, needle));

        haystack = "mississippi";
        needle = "issip";
        expected = 4;
        Assert.AreEqual(expected, solution.StrStr(haystack, needle));
    }

    [TestMethod]
    [Timeout(1000)]
    public void TestSolution_WhenNoOccurrence_ShouldReturnMinus1()
    {
        var solution = new Solution();
        string haystack = "sadbutsad";
        string needle = "cfd";
        Assert.AreEqual(-1, solution.StrStr(haystack, needle));
    }
}