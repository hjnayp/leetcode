using JetBrains.Annotations;
using source._1600._1652;

namespace test._1600;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1652
{
    [TestMethod]
    public void K_Is_More_Than_0()
    {
        var solution = new Solution();
        int[] code = { 5, 7, 1, 4 };
        int k = 3;
        int[] result = solution.Decrypt(code, k);
        int[] expected = { 12, 10, 16, 13 };
        CollectionAssert.AreEquivalent(expected, result);
    }

    [TestMethod]
    public void K_Is_Less_Than_0()
    {
        var solution = new Solution();
        int[] code = { 2, 4, 9, 3 };
        int k = -2;
        int[] result = solution.Decrypt(code, k);
        int[] expected = { 12, 5, 6, 13 };
        CollectionAssert.AreEquivalent(expected, result);
    }

    [TestMethod]
    public void K_Is_0()
    {
        var solution = new Solution();
        int[] code = { 1, 2, 3, 4 };
        int k = 0;
        int[] result = solution.Decrypt(code, k);
        int[] expected = { 0, 0, 0, 0 };
        CollectionAssert.AreEquivalent(expected, result);
    }
}