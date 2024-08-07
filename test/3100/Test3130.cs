using JetBrains.Annotations;
using source._3100;

namespace test._3100;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3130
{
    private Solution _solution = new();

    [TestMethod]
    public void NormalCase()
    {
        Assert.AreEqual(2, _solution.NumberOfStableArrays(1,1,2));
        Assert.AreEqual(1, _solution.NumberOfStableArrays(1,2,1));
        Assert.AreEqual(14, _solution.NumberOfStableArrays(3,3,2));
        
    }
}