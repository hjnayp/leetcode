namespace source._0000._45;

/// <summary>
///     <a href="https://leetcode.cn/problems/jump-game-ii/">
///         Jump Game II
///     </a>
/// </summary>
public class Solution
{
    public int Jump(int[] nums)
    {
        int maxPosition = 0;
        int end = 0;
        int step = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (i > maxPosition) continue;
            maxPosition = Math.Max(maxPosition, nums[i] + i);

            if (i != end) continue;
            end = maxPosition;
            ++step;
        }

        return step;
    }
}