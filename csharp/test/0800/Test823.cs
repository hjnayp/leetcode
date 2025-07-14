using JetBrains.Annotations;
using source._0800._823;
using source.InputParsers;

namespace test._0800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test823
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        Assert.AreEqual(3, solution.NumFactoredBinaryTrees(ArrayParser.ParseOneDimensionalArray<int>("[2,4]")));
        Assert.AreEqual(7, solution.NumFactoredBinaryTrees(ArrayParser.ParseOneDimensionalArray<int>("[2,4,5,10]")));
    }
}