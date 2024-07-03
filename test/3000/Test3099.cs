using JetBrains.Annotations;
using source._3000._3099;

namespace test._3000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3099
{
    private Solution _solution = new();

    [TestMethod]
    public void normal_case()
    {
        Assert.AreEqual(9, _solution.SumOfTheDigitsOfHarshadNumber(18));
    }

    [TestMethod]
    public void not_harshad_case()
    {
        Assert.AreEqual(-1, _solution.SumOfTheDigitsOfHarshadNumber(23));
    }
}