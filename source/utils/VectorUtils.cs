namespace source.utils;

public class VectorUtils
{
    public static bool IsFirstKthElementsSame(int[] arr1, int[] arr2, int k)
    {
        for (int i = 0; i < k; ++i)
        {
            if (arr1[i] != arr2[i]) return false;
        }

        return true;
    }
}