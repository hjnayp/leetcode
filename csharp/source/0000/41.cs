namespace source._0000._41;

/// <summary>
///     <a href="https://leetcode.cn/problems/first-missing-positive/">
///         First Missing Positive
///     </a>
/// </summary>
public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        int n = nums.Length;
        nums = nums.Select(i => i <= 0 ? n + 1 : i).ToArray();
        foreach (int num in nums)
        {
            int absNum = Math.Abs(num);
            if (absNum <= n)
            {
                nums[absNum - 1] = -Math.Abs(nums[absNum - 1]);
            }
        }

        int idx = Array.FindIndex(nums, i => i > 0);
        if (idx == -1) idx = n;
        return idx + 1;
    }
}