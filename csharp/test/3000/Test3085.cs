using JetBrains.Annotations;
using source._3000._3085;

namespace test._3000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3085
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();
        int k = 0;
        string word = "";
        int expected = 0;
        int actual = 0;

        word =
            "eeffmeefexefefffefemeexfeeffeefmfhxemmeeffffmfmmfffeeeffeffeffqffffefmeeeeefffmeffffffefefqfefffmfffmefeeeefexeffffffemffeffffffffemfeefeffffefjefxfffffffemfffffmfffefeemfeffffffmfffffeefefeffxfefefffeefffeqeffeefeemfefeemfffxfxeffffffeffffmfffexfffffee";
        k = 54;
        expected = 49;
        actual = solution.MinimumDeletions(word, k);
        Assert.AreEqual(expected, actual);

        word = "aabcaba";
        k = 0;
        expected = 3;
        actual = solution.MinimumDeletions(word, k);
        Assert.AreEqual(expected, actual);
    }
}