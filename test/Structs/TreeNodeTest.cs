using JetBrains.Annotations;
using source.Structs;

namespace test.Structs;

[TestClass]
[TestSubject(typeof(TreeNode))]
public class TreeNodeTest
{
    [TestMethod]
    public void ConstructTreeCase()
    {
        var root = new int?[] { 1, null, 2, 3 };
        var node = TreeNode.CreateTreeWithList(root);

        Assert.AreEqual(1, node!.val);
        Assert.IsNull(node.left);
        Assert.AreEqual(2, node.right!.val);
        Assert.AreEqual(3, node.right.left!.val);

        root = new int?[] { };
        node = TreeNode.CreateTreeWithList(root);
        Assert.IsNull(node);
    }
}