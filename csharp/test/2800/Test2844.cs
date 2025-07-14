using JetBrains.Annotations;
using source._2800._2844;

namespace test._2800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2844
{
    [TestMethod]
    public void normal_case_0()
    {
        Solution solution = new();
        string num = "2245047";
        Assert.AreEqual(2, solution.MinimumOperations(num));
    }

    [TestMethod]
    public void normal_case_1()
    {
        Solution solution = new();
        string num = "2908305";
        Assert.AreEqual(3, solution.MinimumOperations(num));
    }

    [TestMethod]
    public void normal_case_2()
    {
        Solution solution = new();
        string num = "10";
        Assert.AreEqual(1, solution.MinimumOperations(num));
    }

    [TestMethod]
    public void zero_operation_case()
    {
        Solution solution = new();
        string num = "75";
        Assert.AreEqual(0, solution.MinimumOperations(num));
    }

    [TestMethod]
    public void remove_all_digit_case()
    {
        Solution solution = new();
        string num = "1";
        Assert.AreEqual(1, solution.MinimumOperations(num));
    }
}