namespace source._2900._2908;

/// <summary>
///     https://leetcode.cn/problems/minimum-sum-of-mountain-triplets-i/description
/// </summary>
public class Solution
{
    public int MinimumSum(int[] nums)
    {
        int n = nums.Length;
        if (n < 3) return -1;

        var leftMines = new int[n];
        var rightMines = new int[n];
        var leftMin = int.MaxValue;
        var rightMin = int.MaxValue;
        for (var i = 0; i < n; ++i)
        {
            leftMin = Math.Min(leftMin, nums[i]);
            rightMin = Math.Min(rightMin, nums[^(i + 1)]);
            leftMines[i] = leftMin;
            rightMines[^(i + 1)] = rightMin;
        }

        var res = int.MaxValue;
        for (var i = 1; i < n - 1; ++i)
            if (leftMines[i - 1] < nums[i] && rightMines[i + 1] < nums[i])
                res = Math.Min(res, nums[i] + leftMines[i - 1] + rightMines[i + 1]);
        return res == int.MaxValue ? -1 : res;
    }
}