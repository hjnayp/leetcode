namespace source._2200._2270;

/// <summary>
///     <a href="https://leetcode.cn/problems/number-of-ways-to-split-array">
///         2270. Number of Ways to Split Array
///     </a>
/// </summary>
public class Solution
{
    public int WaysToSplitArray(int[] nums)
    {
        long sum = nums.Sum(i => (long)i);
        long preSum = 0;
        int res = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            int num = nums[i];
            preSum += num;
            sum -= num;

            if (preSum >= sum)
            {
                ++res;
            }
        }

        return res;
    }
}