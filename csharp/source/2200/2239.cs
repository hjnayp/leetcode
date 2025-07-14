namespace source._2200._2239;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-closest-number-to-zero">
///         2239. Find Closest Number to Zero
///     </a>
/// </summary>
public class Solution
{
    public int FindClosestNumber(int[] nums)
    {
        int min = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            int num = nums[i];
            if (Math.Abs(num) < Math.Abs(min))
            {
                min = num;
            }
            else if (Math.Abs(num) == Math.Abs(min))
            {
                min = Math.Max(min, num);
            }
        }

        return min;
    }
}