namespace source._2900._2962;

/// <summary>
///     <a href="https://leetcode.cn/problems/count-subarrays-where-max-element-appears-at-least-k-times">
///         2962. Count Subarrays Where Max Element Appears at Least K Times
///     </a>
/// </summary>
public class Solution
{
    public long CountSubarrays(int[] nums, int k)
    {
        int m = nums.Max();
        long res = 0L;
        int left = 0;
        int right = 0;
        int count = 0;
        while (right < nums.Length)
        {
            if (nums[right] == m)
            {
                ++count;
            }

            while (count == k)
            {
                if (nums[left] == m)
                {
                    --count;
                }

                ++left;
            }

            res += left;
            ++right;
        }

        return res;
    }
}