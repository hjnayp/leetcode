using JetBrains.Annotations;
using source._0500._522;
using source.InputParsers;

namespace test._0500;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test522
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();

        string[] strs = ArrayParser.ParseOneDimensionalArray<string>("[\"aba\",\"cdc\",\"eae\"]");
        Assert.AreEqual(3, solution.FindLUSlength(strs));
    }

    [TestMethod]
    public void edge_case()
    {
        Solution solution = new();

        string[] strs = ArrayParser.ParseOneDimensionalArray<string>("[\"aaa\",\"aaa\",\"aa\"]");
        Assert.AreEqual(-1, solution.FindLUSlength(strs));
    }
}