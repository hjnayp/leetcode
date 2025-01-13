using JetBrains.Annotations;
using source._1600._1609;
using source.Structs;

namespace test._1600;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1690
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();
        TreeNode? node = null;
        bool expected = false;

        node = TreeNode.CreateTreeWithList([1, 10, 4, 3, null, 7, 9, 12, 8, 6, null, null, 2]);
        expected = true;
        Assert.AreEqual(expected, solution.IsEvenOddTree(node));

        node = TreeNode.CreateTreeWithList([5, 4, 2, 3, 3, 7]);
        expected = false;
        Assert.AreEqual(expected, solution.IsEvenOddTree(node));

        node = TreeNode.CreateTreeWithList([5, 9, 1, 3, 5, 7]);
        expected = false;
        Assert.AreEqual(expected, solution.IsEvenOddTree(node));
    }
}