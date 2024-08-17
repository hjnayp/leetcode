using JetBrains.Annotations;
using source._0000._14;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test14
{
    [TestMethod]
    public void NormalCase()
    {
        Solution solution = new Solution();
        string[] strs = ["flower", "flow", "flight"];
        Assert.AreEqual("fl", solution.LongestCommonPrefix(strs));

        strs = ["dog", "racecar", "car"];
        Assert.AreEqual("", solution.LongestCommonPrefix(strs));
    }
}