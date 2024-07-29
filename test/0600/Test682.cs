using JetBrains.Annotations;
using source._0600._682;

namespace test._0600;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test682
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        string[] operations = ["5", "2", "C", "D", "+"];
        Assert.AreEqual(30, solution.CalPoints(operations));
    }

    [TestMethod]
    public void normal_case_2()
    {
        Solution solution = new();
        string[] operations = ["5", "-2", "4", "C", "D", "9", "+", "+"];
        Assert.AreEqual(27, solution.CalPoints(operations));
    }

    [TestMethod]
    public void normal_case_3()
    {
        Solution solution = new();
        string[] operations = ["1", "C"];
        Assert.AreEqual(0, solution.CalPoints(operations));
    }
}