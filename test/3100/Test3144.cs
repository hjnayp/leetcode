using JetBrains.Annotations;
using source._3100._3144;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3144
{

    [TestMethod]
    public void NormalCase()
    {
        var solution = new Solution();
        var str = "fabccddg";
        Assert.AreEqual(3, solution.MinimumSubstringsInPartition(str));
        
        str = "abababaccddb";
        Assert.AreEqual(2, solution.MinimumSubstringsInPartition(str));
    }
}