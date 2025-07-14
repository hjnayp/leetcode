using JetBrains.Annotations;
using source._2200._2207;

namespace test._2200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2207
{
    [TestMethod]
    public void TestSolution()
    {
        RunTest(4, "abdcdbc", "ac");
        RunTest(6, "aabb", "ab");
        RunTest(1, "fwymvreuftzgrcrxczjacqovduqaiig", "yy");
        RunTest(3, "fwymvreuftzgrcrxczjacqovdyuqaiig", "yy");
    }

    private static void RunTest(long expected, string text, string pattern)
    {
        Solution solution = new();
        Assert.AreEqual(expected, solution.MaximumSubsequenceCount(text, pattern));
    }
}