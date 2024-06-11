using JetBrains.Annotations;
using source._0400._419;
using source.InputParsers;

namespace test._0400;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test419
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        char[][] chars = ArrayParser.ParseTwoDimensionalArray<char>(
            "[['X','.','.','X'],['.','.','.','X'],['.','.','.','X']]");
        Assert.AreEqual(2, solution.CountBattleships(chars));
        chars = ArrayParser.ParseTwoDimensionalArray<char>("[['.']]");
        Assert.AreEqual(0, solution.CountBattleships(chars));
    }
}