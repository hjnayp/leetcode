using JetBrains.Annotations;
using source._3000._3001;

namespace test._3000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test3001
{
    private Solution solution = new();

    [TestMethod]
    public void TestSolution()
    {
        Assert.AreEqual(2, solution.MinMovesToCaptureTheQueen(1, 1, 8, 8, 2, 3));
        Assert.AreEqual(1, solution.MinMovesToCaptureTheQueen(5, 3, 3, 4, 5, 2));
        Assert.AreEqual(1, solution.MinMovesToCaptureTheQueen(1, 1, 1, 4, 1, 3));
        Assert.AreEqual(2, solution.MinMovesToCaptureTheQueen(1, 1, 4, 1, 5, 3));
        Assert.AreEqual(1, solution.MinMovesToCaptureTheQueen(1, 1, 8, 1, 5, 1));
        Assert.AreEqual(1, solution.MinMovesToCaptureTheQueen(2, 1, 1, 1, 3, 3));
    }
}