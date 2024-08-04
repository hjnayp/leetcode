using JetBrains.Annotations;
using source._0500._572;
using source.Structs;

namespace test._0500;

[TestClass, TestSubject(typeof(Solution))]
public class Test572
{
    private readonly Solution _solution = new();

    [TestMethod]
    public void NormalCase()
    {
        var rootTree = TreeNode.CreateTreeWithList([3, 4, 5, 1, 2]);
        var subRootTree = TreeNode.CreateTreeWithList([4, 1, 2]);
        Assert.IsTrue(_solution.IsSubtree(rootTree, subRootTree));

        rootTree = TreeNode.CreateTreeWithList([1, 1]);
        subRootTree = TreeNode.CreateTreeWithList([1]);
        Assert.IsTrue(_solution.IsSubtree(rootTree, subRootTree));

        rootTree = TreeNode.CreateTreeWithList([3, 4, 5, 1, 2, null, null, null, null, 0]);
        subRootTree = TreeNode.CreateTreeWithList([4, 1, 2]);
        Assert.IsFalse(_solution.IsSubtree(rootTree, subRootTree));

        rootTree = TreeNode.CreateTreeWithList([1, 2, 3]);
        subRootTree = TreeNode.CreateTreeWithList([1, 2]);
        Assert.IsFalse(_solution.IsSubtree(rootTree, subRootTree));

        rootTree = TreeNode.CreateTreeWithList([3, 4, 5, 1, null, 2]);
        subRootTree = TreeNode.CreateTreeWithList([3, 1, 2]);
        Assert.IsFalse(_solution.IsSubtree(rootTree, subRootTree));   
        
        rootTree = TreeNode.CreateTreeWithList([12]);
        subRootTree = TreeNode.CreateTreeWithList([2]);
        Assert.IsFalse(_solution.IsSubtree(rootTree, subRootTree));

        rootTree = TreeNode.CreateTreeWithList([
            4, -9, 5, null, -1, null, 8, -6, 0, 7, null, null, -2, null, null, null, null, -3
        ]);
        subRootTree = TreeNode.CreateTreeWithList([5]);
        Assert.IsFalse(_solution.IsSubtree(rootTree, subRootTree));
    }
}