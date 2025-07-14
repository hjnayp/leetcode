namespace source._3100._3176;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-the-maximum-length-of-a-good-subsequence-i">
///         Find the  Maximum Length of a Good Subsequence I
///     </a>
/// </summary>
public class Solution
{
    public int MaximumLength(int[] nums, int k)
    {
        int n = nums.Length;
        int[,] dp = new int[n, k + 1];
        for (int i = 0; i < n; ++i)
        for (int j = 0; j <= k; ++j)
        {
            dp[i, j] = -1;
        }

        int maxLength = 0;
        for (int i = 0; i < n; ++i)
        {
            // Try to add nums[j] to the subsequence end
            dp[i, 0] = 1;
            for (int diff = 0; diff <= k; ++diff)
            {
                for (int j = 0; j < i; ++j)
                {
                    int addDiff = nums[i] != nums[j] ? 1 : 0;
                    int newDiff = diff - addDiff;
                    if (newDiff >= 0 && dp[j, newDiff] != -1)
                    {
                        dp[i, diff] = Math.Max(dp[i, diff], dp[j, newDiff] + 1);
                    }
                }

                maxLength = Math.Max(maxLength, dp[i, diff]);
            }
        }

        return maxLength;
    }
}