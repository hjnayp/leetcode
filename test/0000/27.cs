using source._0000._27;
using test.utils;

namespace test._0000;

[TestClass]
public class Test27
{
    [TestMethod]
    [Timeout(1500)]
    public void NormalCase()
    {
        int[] input_arr = { 3, 2, 2, 3 };
        var input_val = 3;
        int[] res = { 2, 2 };
        var actual = new Solution().RemoveElement(input_arr, input_val);
        Assert.AreEqual(res.Length, actual);
        Assert.IsTrue(VectorUtils.IsFirstKthElementsSame(input_arr, res, actual));

        input_arr = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        input_val = 2;
        res = new[] { 0, 1, 4, 0, 3 };
        actual = new Solution().RemoveElement(input_arr, input_val);
        Assert.AreEqual(res.Length, actual);
        Assert.IsTrue(VectorUtils.IsFirstKthElementsSame(input_arr, res, actual));
    }
}