using JetBrains.Annotations;
using source._2800._2810;

namespace test._2800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2810
{
    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var s = "string";
        Assert.AreEqual("rtsng", solution.FinalString(s));

        s = "poiinter";
        Assert.AreEqual("ponter", solution.FinalString(s));
    }
}