using JetBrains.Annotations;
using source._3100._3115;
using source.InputParsers;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3115
{
    private Solution _solution = new();
    private int[] _nums;

    [TestMethod]
    public void normal_case_00()
    {
        RunCase("[4,2,9,5,3]", 3);
    }

    [TestMethod]
    public void only_one_prime_case()
    {
        RunCase("[4,8,2,8]", 0);
    }

    [Timeout(1000)]
    private void RunCase(string input, int expected)
    {
        _nums = ArrayParser.ParseOneDimensionalArray<int>(input);
        Assert.AreEqual(expected, _solution.MaximumPrimeDifference(_nums));
    }
}