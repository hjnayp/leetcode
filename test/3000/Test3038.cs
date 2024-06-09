using JetBrains.Annotations;
using source._3000._3038;
using source.InputParsers;

namespace test._3000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3038
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        Assert.AreEqual(2, solution.MaxOperations(ArrayParser.ParseOneDimensionalArray("[3,2,1,4,5]")));
        Assert.AreEqual(1, solution.MaxOperations(ArrayParser.ParseOneDimensionalArray("[3,2,6,1,4]")));
    }
}