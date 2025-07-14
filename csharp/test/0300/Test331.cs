using JetBrains.Annotations;
using source._0300._331;

namespace test._0300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test331
{

    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var preorder = "9,3,4,#,#,1,#,#,2,#,6,#,#";
        Assert.IsTrue(solution.IsValidSerialization(preorder));

        preorder = "1,#";
        Assert.IsFalse(solution.IsValidSerialization(preorder));

        preorder = "9,#,#,1";
        Assert.IsFalse(solution.IsValidSerialization(preorder));
    }
}