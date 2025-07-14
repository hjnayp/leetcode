using JetBrains.Annotations;
using source._3300._3305;

namespace test._3300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3305
{
    [TestMethod]
    public void TestCase1()
    {
        var solution = new Solution();
        string word = "iqeaouqi";
        int k = 2;
        int expected = 3;
        Assert.AreEqual(expected, solution.CountOfSubstrings(word, k));

        word = "ieiaoud";
        k = 0;
        expected = 2;
        Assert.AreEqual(expected, solution.CountOfSubstrings(word, k));
    }
}