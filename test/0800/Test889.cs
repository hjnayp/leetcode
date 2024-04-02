using JetBrains.Annotations;
using source._0800._889;
using source.Structs;

namespace test._0800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test889
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var preorder = new[] { 1, 2, 4, 5, 3, 6, 7 };
        var postorder = new[] { 4, 5, 2, 6, 7, 3, 1 };
        var expected = TreeNode.CreateTreeWithList(new int?[] { 1, 2, 3, 4, 5, 6, 7 });
        Assert.AreEqual(expected, solution.ConstructFromPrePost(preorder, postorder));

        preorder = new[] { 1 };
        postorder = new[] { 1 };
        expected = TreeNode.CreateTreeWithList(new int?[] { 1 });
        Assert.AreEqual(expected, solution.ConstructFromPrePost(preorder, postorder));
    }
}