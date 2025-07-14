using JetBrains.Annotations;
using source._3300._3304;

namespace test._3300;

[TestClass, TestSubject(typeof(Solution))]
public class Test3304
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();
        int k;
        char expected;

        k = 5;
        expected = 'b';
        Assert.AreEqual(expected, solution.KthCharacter(k));
    }
}