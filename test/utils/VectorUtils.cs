namespace test.utils;

public class VectorUtils
{
    public static bool IsFirstKthElementsSame(int[] arr1, int[] arr2, int k)
    {
        for (var i = 0; i < k; ++i)
            if (arr1[i] != arr2[i])
                return false;

        return true;
    }

    public static bool IsVectorElementsSame(IList<int> arr1, IList<int> arr2)
    {
        if (arr1.Count != arr2.Count)
            return false;

        return !arr1.Where((t, i) => t != arr2[i]).Any();
    }
}