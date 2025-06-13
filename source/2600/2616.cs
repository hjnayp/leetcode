namespace source._2600._2616;

/// <summary>
///     <a href="https://leetcode.cn/problems/minimize-the-maximum-difference-of-pairs">
///         2616. Minimize the Maximum Difference of Pairs
///     </a>
/// </summary>
public class Solution
{
    public int MinimizeMax(int[] nums, int p)
    {
        Array.Sort(nums);
        int left = 0;
        int right = nums[^1] - nums[0];

        while (left < right)
        {
            int mid = (right - left) / 2 + left;
            int count = 0;
            for (int i = 0; i < nums.Length - 1; ++i)
            {
                if (Math.Abs(nums[i] - nums[i + 1]) > mid) continue;

                ++count;
                ++i;
            }

            if (count >= p)
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }
}