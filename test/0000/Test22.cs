using JetBrains.Annotations;
using source._0000._22;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test22
{
    [TestMethod]
    public void TestSolution()
    {
        Solution solution = new();

        string[] expected = ["()"];
        CollectionAssert.AreEqual(expected, solution.GenerateParenthesis(1).ToArray());

        expected = ["((()))", "(()())", "(())()", "()(())", "()()()"];
        CollectionAssert.AreEqual(expected, solution.GenerateParenthesis(3).ToArray());
    }
}