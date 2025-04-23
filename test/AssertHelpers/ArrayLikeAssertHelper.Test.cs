using JetBrains.Annotations;

namespace test.AssertHelpers;

[TestClass]
[TestSubject(typeof(ArrayLikeAssertHelper<>))]
public class ArrayLikeAssertHelperTest
{
    [TestMethod]
    public void TestAreEquivalent_WhenArrayContainsSameElements()
    {
        int[] arr1 = [1, 2, 3];
        int[] arr2 = [2, 1, 3];
        IList<int> list1 = [1, 2, 3];
        IList<int> list2 = [3, 1, 2];

        ArrayLikeAssertHelper<int>.AreEquivalent(arr1, arr2);
        ArrayLikeAssertHelper<int>.AreEquivalent(list1, list2);
        ArrayLikeAssertHelper<int>.AreEquivalent(arr1, list2);
        ArrayLikeAssertHelper<int>.AreEquivalent(list1, arr2);
    }

    [TestMethod]
    public void TestAreEquivalent_WhenArrayContainsDifferentElements()
    {
        int[] arr1 = [1, 2, 3];
        int[] arr2 = [2, 1, 4];
        IList<int> list1 = [1, 2, 3];
        IList<int> list2 = [3, 1, 4];

        Assert.ThrowsException<AssertFailedException>(() => { ArrayLikeAssertHelper<int>.AreEquivalent(arr1, arr2); });
        Assert.ThrowsException<AssertFailedException>(() =>
        {
            ArrayLikeAssertHelper<int>.AreEquivalent(list1, list2);
        });
        Assert.ThrowsException<AssertFailedException>(() => { ArrayLikeAssertHelper<int>.AreEquivalent(arr1, list2); });
        Assert.ThrowsException<AssertFailedException>(() => { ArrayLikeAssertHelper<int>.AreEquivalent(list1, arr2); });
    }

    [TestMethod]
    public void TestAreEqual()
    {
        int[] arr1 = [1, 2, 3];
        int[] arr2 = [2, 1, 3];
        IList<int> list1 = [1, 2, 3];
        IList<int> list2 = [3, 1, 2];

        Assert.ThrowsException<AssertFailedException>(() => { ArrayLikeAssertHelper<int>.AreEqual(arr1, arr2); });
        Assert.ThrowsException<AssertFailedException>(() => { ArrayLikeAssertHelper<int>.AreEqual(list1, list2); });
        Assert.ThrowsException<AssertFailedException>(() => { ArrayLikeAssertHelper<int>.AreEqual(arr1, list2); });
        Assert.ThrowsException<AssertFailedException>(() => { ArrayLikeAssertHelper<int>.AreEqual(list1, arr2); });

        ArrayLikeAssertHelper<int>.AreEqual(arr1, list1);
        ArrayLikeAssertHelper<int>.AreEqual(list1, arr1);
        ArrayLikeAssertHelper<int>.AreEqual(arr1, arr1);
        ArrayLikeAssertHelper<int>.AreEqual(list1, list1);
    }
}