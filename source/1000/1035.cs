namespace source._1000._1035;

public class Solution
{
    public int MaxUncrossedLines(int[] nums1, int[] nums2)
    {
        int m = nums1.Length;
        int n = nums2.Length;
        int[,] lineCounts = new int[m + 1, n + 1];

        for (int i = 1; i <= m; ++i)
        for (int j = 1; j <= n; ++j)
        {
            if (IsDrawLineAble(i, j))
            {
                lineCounts[i, j] = lineCounts[i - 1, j - 1] + 1;
            }
            else
            {
                lineCounts[i, j] = Math.Max(lineCounts[i, j - 1], lineCounts[i - 1, j]);
            }
        }

        return lineCounts[m, n];

        bool IsDrawLineAble(int index1From1, int index2From1)
        {
            return nums1[index1From1 - 1] == nums2[index2From1 - 1];
        }
    }
}   