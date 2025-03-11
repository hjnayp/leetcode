namespace source._2000._2012;

/// <summary>
///     <a href="https://leetcode.cn/problems/sum-of-beauty-in-the-array">
///         2012. Sum of Beauty in the Array
///     </a>
/// </summary>
public class Solution
{
    public int SumOfBeauties(int[] nums)
    {
        int beautyCount = 0;
        int n = nums.Length;
        int[] leftMax = new int[n];
        int[] rightMin = new int[n];

        int max = nums[0];
        int min = nums[^1];

        leftMax[0] = max;
        rightMin[^1] = min;

        for (int i = 1; i < nums.Length - 1; i++)
        {
            max = Math.Max(max, nums[i - 1]);
            min = Math.Min(min, nums[^i]);
            leftMax[i] = max;
            rightMin[^(i + 1)] = min;
        }

        for (int i = 1; i < nums.Length - 1; i++)
        {
            int num = nums[i];
            if (leftMax[i] < num && num < rightMin[i])
            {
                beautyCount += 2;
            }
            else if (nums[i - 1] < num && num < nums[i + 1])
            {
                beautyCount += 1;
            }
        }

        return beautyCount;
    }
}