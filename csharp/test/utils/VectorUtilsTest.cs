using JetBrains.Annotations;
using source.utils;

namespace test.utils;

[TestClass]
[TestSubject(typeof(VectorUtils))]
public class VectorUtilsTest
{
    [TestMethod]
    public void all_same_case()
    {
        int[] arr1 = [1, 2, 3, 4];
        int[] arr2 = [1, 2, 3, 4];
        Assert.IsTrue(VectorUtils.IsFirstKthElementsSame(arr1, arr2, arr1.Length));
    }

    [TestMethod]
    public void first_k_same()
    {
        int[] arr1 = [1, 2, 3, 4, 6];
        int[] arr2 = [1, 2, 3, 4, 5];
        Assert.IsTrue(VectorUtils.IsFirstKthElementsSame(arr1, arr2, 4));
        Assert.IsFalse(VectorUtils.IsFirstKthElementsSame(arr1, arr2, 5));
    }
}