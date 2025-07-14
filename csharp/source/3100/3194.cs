namespace source._3100._3194;

/// <summary>
///     <a href="https://leetcode.cn/problems/minimum-average-of-smallest-and-largest-elements">
///         Minimum Average of Smallest and Largest Elements
///     </a>
/// </summary>
public class Solution
{
    public double MinimumAverage(int[] nums)
    {
        int n = nums.Length;
        int count = n / 2;
        Array.Sort(nums);
        double min = int.MaxValue;
        for (int i = 0; i < count; ++i)
        {
            double aver = (nums[i] + nums[^(i + 1)]) / 2.0;
            min = Math.Min(min, aver);
        }

        return min;
    }
}