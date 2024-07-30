namespace source._0000._04;

/// <summary>
///     https://leetcode.cn/problems/median-of-two-sorted-arrays
/// </summary>
public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int m = nums1.Length;
        int n = nums2.Length;
        int len = m + n;
        int k1 = (len + 1) / 2;
        int k2 = (len + 2) / 2;
        float median = (FindKthValue(k1) + FindKthValue(k2)) / 2f;

        return median;

        int FindKthValue(int k)
        {
            int i = 0;
            int j = 0;
            while (true)
            {
                if (i == m)
                {
                    return nums2[j + k - 1];
                }

                if (j == n)
                {
                    return nums1[i + k - 1];
                }

                if (k == 1)
                {
                    return Math.Min(nums1[i], nums2[j]);
                }

                int idx1 = Math.Min(m - 1, i + k / 2 - 1);
                int idx2 = Math.Min(n - 1, j + k / 2 - 1);

                if (nums1[idx1] <= nums2[idx2])
                {
                    k -= idx1 - i + 1;
                    i = idx1 + 1;
                }
                else
                {
                    k -= idx2 - j + 1;
                    j = idx2 + 1;
                }
            }
        }
    }
}