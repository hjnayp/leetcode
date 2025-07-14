using JetBrains.Annotations;
using source._0000._27;
using source.utils;

namespace test._0000;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test27
{
    [TestMethod]
    [Timeout(1500)]
    public void NormalCase()
    {
        int[] inputArr = { 3, 2, 2, 3 };
        int inputVal = 3;
        int[] res = { 2, 2 };
        int actual = new Solution().RemoveElement(inputArr, inputVal);
        Assert.AreEqual(res.Length, actual);
        Assert.IsTrue(VectorUtils.IsFirstKthElementsSame(inputArr, res, actual));

        inputArr = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        inputVal = 2;
        res = new[] { 0, 1, 4, 0, 3 };
        actual = new Solution().RemoveElement(inputArr, inputVal);
        Assert.AreEqual(res.Length, actual);
        Assert.IsTrue(VectorUtils.IsFirstKthElementsSame(inputArr, res, actual));

        inputArr = new[] { 1, 2, 3, 3 };
        inputVal = 3;
        res = new[] { 1, 2 };
        actual = new Solution().RemoveElement(inputArr, inputVal);
        Assert.AreEqual(res.Length, actual);
        Assert.IsTrue(VectorUtils.IsFirstKthElementsSame(inputArr, res, actual));
    }
}