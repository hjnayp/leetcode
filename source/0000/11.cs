namespace source._0000._11;

/// <summary>
///     https://leetcode.cn/problems/container-with-most-water/
/// </summary>
public class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;
        while (left < right)
        {
            maxArea = Math.Max(maxArea, (right - left) * Math.Min(height[left], height[right]));
            if (height[left] < height[right])
            {
                ++left;
            }
            else
            {
                --right;
            }
        }

        return maxArea;
    }
}