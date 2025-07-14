namespace source._2500._2552;

/// <summary>
///     <a href="https://leetcode.cn/problems/count-increasing-quadruplets">
///         Count Increasing Quadruplets
///     </a>
/// </summary>
public class Solution
{
    public long CountQuadruplets(int[] nums)
    {
        int n = nums.Length;
        int[] prefix = new int[n + 1];
        long count = 0;
        for (int j = 0; j < n; ++j)
        {
            int suffix = 0;
            for (int k = n - 1; k > j; --k)
            {
                if (nums[j] > nums[k])
                {
                    count += (long)prefix[nums[k]] * suffix;
                }
                else
                {
                    ++suffix;
                }
            }

            for (int x = nums[j] + 1; x <= n; ++x)
            {
                ++prefix[x];
            }
        }

        return count;
    }
}