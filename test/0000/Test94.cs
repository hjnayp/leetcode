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
        var root = TreeNode.CreateTreeWithList(new List<int?> { 1, null, 2, 3 });
        List<int> actual = solution.InorderTraversal(root).ToList();
        var expected = new List<int> { 1, 3, 2 };
        CollectionAssert.AreEquivalent(expected, actual);

        root = TreeNode.CreateTreeWithList(new int?[] { });
        actual = solution.InorderTraversal(root).ToList();
        expected = new List<int>();
        CollectionAssert.AreEquivalent(expected, actual);

        root = TreeNode.CreateTreeWithList(new int?[] { 1 });
        actual = solution.InorderTraversal(root).ToList();
        expected = new List<int> { 1 };
        CollectionAssert.AreEquivalent(expected, actual);
    }
}