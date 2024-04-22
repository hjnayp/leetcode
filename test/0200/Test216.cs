using JetBrains.Annotations;
using source._0200._216;

namespace test._0200;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test216
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var n = 7;
        var k = 3;
        var expected = new List<List<int>> { new() { 1, 2, 4 } };
        IList<IList<int>> actual = solution.CombinationSum3(k, n);
        for (var i = 0; i < actual.Count; i++)
        {
            IList<int> actualItem = actual[i];
            List<int> expectedItem = expected[i];
            CollectionAssert.AreEqual(expectedItem, actualItem.ToArray());
        }
    }
}