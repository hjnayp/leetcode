using JetBrains.Annotations;
using source._0800._894;
using source.Structs;

namespace test._0800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test894
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var n = 7;
        TreeNode?[] nodes =
        {
            TreeNode.CreateTreeWithList(new int?[] { 0, 0, 0, null, null, 0, 0, null, null, 0, 0 }),
            TreeNode.CreateTreeWithList(new int?[] { 0, 0, 0, null, null, 0, 0, 0, 0 }),
            TreeNode.CreateTreeWithList(new int?[] { 0, 0, 0, 0, 0, 0, 0 }),
            TreeNode.CreateTreeWithList(new int?[] { 0, 0, 0, 0, 0, null, null, null, null, 0, 0 }),
            TreeNode.CreateTreeWithList(new int?[] { 0, 0, 0, 0, 0, null, null, 0, 0 })
        };

        CollectionAssert.AreEquivalent(nodes, solution.AllPossibleFBT(n).ToArray());

        n = 3;
        nodes = new[]
        {
            TreeNode.CreateTreeWithList(new int?[] { 0, 0, 0 })
        };
        CollectionAssert.AreEquivalent(nodes, solution.AllPossibleFBT(n).ToArray());
    }
}