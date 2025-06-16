namespace source._2000._2016;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximum-difference-between-increasing-elements">
///         2016. Maximum Difference Between Increasing Elements
///     </a>
/// </summary>
public class Solution
{
    public int MaximumDifference(int[] nums)
    {
        int diff = -1;
        int premin = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > premin)
            {
                diff = Math.Max(diff, nums[i] - premin);
            }
            else
            {
                premin = nums[i];
            }
        }

        return diff;
    }
}