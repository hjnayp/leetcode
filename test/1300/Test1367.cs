using JetBrains.Annotations;
using source._1300;
using source.Structs;

namespace test._1300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1367
{
    [TestMethod]
    public void TestSolution()
    {
        var solution = new Solution();

        var root = TreeNode.CreateTreeWithList([
            1, 4, 4, null, 2, 2, null, 1, null, 6, 8, null, null, null, null, 1, 3,
        ]);
        if (ListNode.CreateList([4, 2, 8], out var head))
        {
            Assert.IsTrue(solution.IsSubPath(head, root));
        }

        root = TreeNode.CreateTreeWithList([1, 4, 4, null, 2, 2, null, 1, null, 6, 8, null, null, null, null, 1, 3]);
        if (ListNode.CreateList([1, 4, 2, 6], out head))
        {
            Assert.IsTrue(solution.IsSubPath(head, root));
        }

        root = TreeNode.CreateTreeWithList([1, 4, 4, null, 2, 2, null, 1, null, 6, 8, null, null, null, null, 1, 3]);
        if (ListNode.CreateList([1, 4, 2, 6, 8], out head))
        {
            Assert.IsFalse(solution.IsSubPath(head, root));
        }
    }
}