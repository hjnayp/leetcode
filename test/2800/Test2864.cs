using JetBrains.Annotations;
using source._2800._2864;

namespace test._2800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2864
{
    [TestMethod]
    public void Method()
    {
        var solution = new Solution();
        string input = "1";
        string expected = "1";
        string actual = solution.MaximumOddBinaryNumber(input);
        Assert.AreEqual(expected, actual);

        input = "0101";
        expected = "1001";
        actual = solution.MaximumOddBinaryNumber(input);
        Assert.AreEqual(expected, actual);

        input = "101011";
        expected = "111001";
        actual = solution.MaximumOddBinaryNumber(input);
        Assert.AreEqual(expected, actual);
    }
}