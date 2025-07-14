using JetBrains.Annotations;
using source._1800._1847;

namespace test._1800;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test1847
{
    private Solution solution = new();

    [TestMethod]
    public void TestSolution()
    {
        int[][] rooms = [[2, 2], [1, 2], [3, 2]], queries = [[3, 1], [3, 3], [5, 2]];
        int[] expected = [3, -1, 3];
        CollectionAssert.AreEqual(expected, solution.ClosestRoom(rooms, queries));

        rooms = [[1, 4], [2, 3], [3, 5], [4, 1], [5, 2]];
        queries = [[2, 3], [2, 4], [2, 5]];
        expected = [2, 1, 3];
        CollectionAssert.AreEqual(expected, solution.ClosestRoom(rooms, queries));
    }
}