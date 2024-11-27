using JetBrains.Annotations;
using source._1100._1106;

namespace test._1100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1106
{
    private Solution solution = new();
    private string expression;
    private bool expected;

    [TestMethod]
    public void TestSolution()
    {
        expression = "&(|(f))";
        expected = false;
        Assert.AreEqual(expected, solution.ParseBoolExpr(expression));

        expression = "|(f,f,f,t)";
        expected = true;
        Assert.AreEqual(expected, solution.ParseBoolExpr(expression));

        expression = "!(&(f,t))";
        expected = true;
        Assert.AreEqual(expected, solution.ParseBoolExpr(expression));

        expression = "&(t,t,t)";
        expected = true;
        Assert.AreEqual(expected, solution.ParseBoolExpr(expression));
    }
}