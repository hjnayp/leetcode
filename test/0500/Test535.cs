using JetBrains.Annotations;
using source._0500._535;

namespace test._0500;

[TestClass]
[TestSubject(typeof(Codec))]
public class Test535
{
    private Codec _solution = new();

    [TestMethod]
    public void normal_case()
    {
        RunCase("https://leetcode.com/problems/design-tinyurl");
        RunCase("https://leetcode.cn/problems/encode-and-decode-tinyurl/");
    }

    [Timeout(1000)]
    private void RunCase(string url)
    {
        string tinyUrl = _solution.encode(url);
        string originalUrl = _solution.decode(tinyUrl);
        Assert.AreEqual(url, originalUrl);
    }
}