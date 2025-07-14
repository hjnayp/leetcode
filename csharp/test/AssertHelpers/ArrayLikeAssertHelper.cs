namespace test.AssertHelpers;

public abstract class ArrayLikeAssertHelper<T>
{
    public static void AreEquivalent(T[] arrA, T[] arrB)
    {
        CollectionAssert.AreEquivalent(arrA, arrB);
    }

    public static void AreEquivalent(IList<T> arrA, T[] arrB)
    {
        CollectionAssert.AreEquivalent(arrA.ToArray(), arrB);
    }

    public static void AreEquivalent(T[] arrA, IList<T> arrB)
    {
        CollectionAssert.AreEquivalent(arrA, arrB.ToArray());
    }

    public static void AreEquivalent(IList<T> arrA, IList<T> arrB)
    {
        CollectionAssert.AreEquivalent(arrA.ToArray(), arrB.ToArray());
    }

    public static void AreEqual(T[] arrA, T[] arrB)
    {
        CollectionAssert.AreEqual(arrA, arrB);
    }

    public static void AreEqual(IList<T> arrA, T[] arrB)
    {
        CollectionAssert.AreEqual(arrA.ToArray(), arrB);
    }

    public static void AreEqual(T[] arrA, IList<T> arrB)
    {
        CollectionAssert.AreEqual(arrA, arrB.ToArray());
    }

    public static void AreEqual(IList<T> arrA, IList<T> arrB)
    {
        CollectionAssert.AreEqual(arrA.ToArray(), arrB.ToArray());
    }
}