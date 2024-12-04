using JetBrains.Annotations;
using source.LCR._139;

namespace test.LCR;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test139
{
    private Solution solution = new();
    private int[] actions;
    private int[] expected;

    [TestMethod]
    public void TestSolution()
    {
        actions = [1, 2, 3, 4, 5];
        Assert.IsTrue(IsValidResult(solution.TrainingPlan(actions)));
    }

    private static bool IsValidResult(int[] results)
    {
        bool isOdd = true;
        foreach (int result in results)
        {
            if (result % 2 is 1)
            {
                if (isOdd is false) return false;
            }
            else
            {
                if (isOdd) isOdd = false;
            }
        }

        return true;
    }
}