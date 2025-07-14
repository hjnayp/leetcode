using JetBrains.Annotations;
using source._2300._2385;
using source.Structs;

namespace test._2300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2385
{
    [TestMethod]
    public void Normal()
    {
        var solution = new Solution();
        var tree = TreeNode.CreateTreeWithList(new int?[] { 1, 5, 3, null, 4, 10, 6, 9, 2 });
        var start = 3;
        int actual = solution.AmountOfTime(tree, 3);
        Assert.AreEqual(4, actual);
    }
}