using JetBrains.Annotations;
using source._3300._3307;

namespace test._3300;

[TestClass, TestSubject(typeof(Solution))]
public class Test3307
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();

        int[] operations = [0, 0, 0];
        long k = 5;
        char expected = 'a';
        Assert.AreEqual(expected, solution.KthCharacter(k, operations));

        operations = [0, 1, 0, 1];
        expected = 'b';
        k = 10;
        Assert.AreEqual(expected, solution.KthCharacter(k, operations));

        operations =
            [0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 1, 1, 1, 1, 1];
        expected = 'i';
        k = 12145134613;
        Assert.AreEqual(expected, solution.KthCharacter(k, operations));
    }
}