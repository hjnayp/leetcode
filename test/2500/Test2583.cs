using JetBrains.Annotations;
using source._2500._2583;
using source.Structs;

namespace test._2500;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2583
{
    [TestMethod]
    public void normal_case()
    {
        var solution = new Solution();
        var root = TreeNode.CreateTreeWithList(new int?[] { 5, 8, 9, 2, 1, 3, 7, 4, 6 });
        int k = 2;
        Assert.AreEqual(13, solution.KthLargestLevelSum(root, k));

        root = TreeNode.CreateTreeWithList(new int?[] { 1, 2, null, 3 });
        k = 1;
        Assert.AreEqual(3, solution.KthLargestLevelSum(root, k));
    }

    [TestMethod]
    public void level_fewer_than_k_case()
    {
        var solution = new Solution();
        var root = TreeNode.CreateTreeWithList(new int?[] { 1, 2, null, 3 });
        int k = 10;
        Assert.AreEqual(-1, solution.KthLargestLevelSum(root, k));

        root = TreeNode.CreateTreeWithList(new int?[] { 5, 8, 9, 2, 1, 3, 7 });
        k = 4;
        Assert.AreEqual(-1, solution.KthLargestLevelSum(root, k));
    }
}