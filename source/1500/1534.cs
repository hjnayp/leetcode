namespace source._1500._1534;

/// <summary>
///     <a href="https://leetcode.cn/problems/count-good-triplets">
///         1534. Count Good Triplets
///     </a>
/// </summary>
public class Solution
{
    public int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        int len = arr.Length;
        int goodTripleCount = 0;
        for (int i = 0; i < len; i++)
        {
            int vI = arr[i];
            for (int j = i + 1; j < len; j++)
            {
                int vJ = arr[j];
                for (int k = j + 1; k < len; k++)
                {
                    int vK = arr[k];
                    goodTripleCount += isGood(vI, vJ, vK) ? 1 : 0;
                }
            }
        }

        return goodTripleCount;

        bool isGood(int v1, int v2, int v3)
        {
            int diff1 = Math.Abs(v1 - v2);
            int diff2 = Math.Abs(v2 - v3);
            int diff3 = Math.Abs(v1 - v3);
            return diff1 <= a && diff2 <= b && diff3 <= c;
        }
    }
}