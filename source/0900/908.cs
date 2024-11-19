namespace source._0900._908;

/// <summary>
///     <a href="https://leetcode.cn/problems/smallest-range-i">
///         Smallest Range I
///     </a>
/// </summary>
public class Solution
{
    public int SmallestRangeI(int[] nums, int k)
    {
        int min = nums[0],
            max = nums[0];

        foreach (var num in nums)
        {
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        return Math.Max(0, max - min - 2 * k);
    }
}