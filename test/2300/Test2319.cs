using JetBrains.Annotations;
using source._2300._2319;

namespace test._2300;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test2319
{
    [TestMethod]
    public void normal_case()
    {
        Solution solution = new();
        int[][] grid =
        [
            [2, 0, 0, 1],
            [0, 3, 1, 0],
            [0, 5, 2, 0],
            [4, 0, 0, 2]
        ];
        Assert.IsTrue(solution.CheckXMatrix(grid));

        grid =
        [
            [5, 7, 0],
            [0, 3, 1],
            [0, 7, 0]
        ];
        Assert.IsFalse(solution.CheckXMatrix(grid));
    }
}