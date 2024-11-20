using JetBrains.Annotations;
using source.Structs;

namespace test.Structs;

[TestClass]
[TestSubject(typeof(SegmentTree2))]
public class SegmentTree2Test
{
    [TestMethod]
    public void TestSum()
    {
        var tree = new SegmentTree2([1, 1, 1]);
        Assert.AreEqual(1, tree.SumRange(0, 0));
        Assert.AreEqual(1, tree.SumRange(1, 1));
        Assert.AreEqual(1, tree.SumRange(2, 2));

        Assert.AreEqual(2, tree.SumRange(0, 1));
        Assert.AreEqual(2, tree.SumRange(1, 2));

        Assert.AreEqual(3, tree.SumRange(0, 2));
    }

    [TestMethod]
    public void TestSumAfterUpdateOneValue()
    {
        var tree = new SegmentTree2([1, 1, 1]);
        tree.UpdateRange(0, 0, 2);
        Assert.AreEqual(2, tree.SumRange(0, 0));
        Assert.AreEqual(4, tree.SumRange(0, 2));
        Assert.AreEqual(2, tree.SumRange(1, 2));
    }

    [TestMethod]
    public void TestSumAfterUpdateRangeValue()
    {
        var tree = new SegmentTree2([1, 1, 1]);
        tree.UpdateRange(0, 2, 2);
        Assert.AreEqual(2, tree.SumRange(0, 0));
        Assert.AreEqual(6, tree.SumRange(0, 2));
        Assert.AreEqual(4, tree.SumRange(1, 2));

        tree = new SegmentTree2(6);
        tree.UpdateRange(4, 4, 1);
        Assert.AreEqual(1, tree.SumRange(4, 4));
        Assert.AreEqual(1, tree.SumRange(3, 4));
    }
}