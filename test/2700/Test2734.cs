using JetBrains.Annotations;
using source._2700._2734;

namespace test._2700;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2734
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();

        Assert.AreEqual("baabc", solution.SmallestString("cbabc"));
        Assert.AreEqual("az", solution.SmallestString("aa"));
        Assert.AreEqual("abaab", solution.SmallestString("acbbc"));
        Assert.AreEqual("kddsbncd", solution.SmallestString("leetcode"));
    }
}