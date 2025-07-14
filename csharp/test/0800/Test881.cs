using JetBrains.Annotations;
using source._0800._881;
using source.InputParsers;

namespace test._0800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test881
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        Assert.AreEqual(1, solution.NumRescueBoats(ArrayParser.ParseOneDimensionalArray<int>("[1,2]"), 3));
        Assert.AreEqual(3, solution.NumRescueBoats(ArrayParser.ParseOneDimensionalArray<int>("[3,2,2,1]"), 3));
        Assert.AreEqual(4, solution.NumRescueBoats(ArrayParser.ParseOneDimensionalArray<int>("[3,5,3,4]"), 5));
    }
}