using JetBrains.Annotations;
using source._1300._1379;
using source.Structs;

namespace test._1300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1379
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();

        var origin = TreeNode.CreateTreeWithList(new int?[]
        {
            7, 4, 3, null, null, 6, 19
        });

        var cloned = TreeNode.CreateTreeWithList(new int?[]
        {
            7, 4, 3, null, null, 6, 19
        });

        TreeNode? target = origin.right;
        TreeNode? clonedTarget = cloned.right;

        Assert.AreEqual(clonedTarget, solution.GetTargetCopy(origin, cloned, target));

        origin = TreeNode.CreateTreeWithList(new int?[] { 7 });
        cloned = TreeNode.CreateTreeWithList(new int?[] { 7 });
        target = origin;
        clonedTarget = cloned;
        Assert.AreEqual(clonedTarget, solution.GetTargetCopy(origin, cloned, target));

        origin = TreeNode.CreateTreeWithList(new int?[] { 8, null, 6, null, 5, null, 4, null, 3, null, 2, null, 1 });
        cloned = TreeNode.CreateTreeWithList(new int?[] { 8, null, 6, null, 5, null, 4, null, 3, null, 2, null, 1 });
        target = origin.right.right.right;
        clonedTarget = cloned.right.right.right;
        Assert.AreEqual(clonedTarget, solution.GetTargetCopy(origin, cloned, target));
    }
}