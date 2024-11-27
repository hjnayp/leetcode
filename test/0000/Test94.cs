using JetBrains.Annotations;
using source._0000._94;
using source.Structs;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test94
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var root = TreeNode.CreateTreeWithList([1, null, 2, 3]);
        int[] actual = solution.InorderTraversal(root).ToArray();
        int[] expected = [1, 3, 2];
        CollectionAssert.AreEqual(expected, actual);

        root = TreeNode.CreateTreeWithList([]);
        actual = solution.InorderTraversal(root).ToArray();
        expected = [];
        CollectionAssert.AreEqual(expected, actual);

        root = TreeNode.CreateTreeWithList([1]);
        actual = solution.InorderTraversal(root).ToArray();
        expected = [1];
        CollectionAssert.AreEqual(expected, actual);
    }
}