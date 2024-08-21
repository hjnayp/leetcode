using JetBrains.Annotations;
using source._0500._551;

namespace test._0500;

[TestClass, TestSubject(typeof(Solution))]
public class Test551
{

    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        Assert.IsTrue(solution.CheckRecord("PPALLP"));
        Assert.IsFalse(solution.CheckRecord("PPALLL"));
        Assert.IsFalse(solution.CheckRecord("PPAAALL"));
    }
}