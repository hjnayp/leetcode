using JetBrains.Annotations;
using source._0000._19;
using source.Structs;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test19
{
    [TestMethod]
    public void NormalCase()
    {
        RunTest(
            [1, 2, 3, 4, 5],
            2,
            [1, 2, 3, 5]
        );
        RunTest(
            [1, 2, 3, 4, 5],
            1,
            [1, 2, 3, 4]
        );
        RunTest(
            [1, 2, 3, 4, 5],
            5,
            [2, 3, 4, 5]
        );
        RunTest(
            [1],
            1,
            []
        );
        RunTest(
            [1, 2],
            1,
            [1]
        );
        RunTest(
            [1, 2],
            2,
            [2]
        );
    }

    private void RunTest(int[] arr, int n, int[] expectedArr)
    {
        var solution = new Solution();
        ListNode? head = ListNode.FromArray(arr);
        ListNode? result = solution.RemoveNthFromEnd(head, n);
        ListNode? expected = ListNode.FromArray(expectedArr);
        Assert.IsTrue(ListNode.CompareListNodeEquivalent(expected, result));
    }
}