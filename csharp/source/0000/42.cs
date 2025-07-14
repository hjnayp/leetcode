namespace source._0000._42;

/// <summary>
///     <a href="https://leetcode.cn/problems/trapping-rain-water">
///         Trapping Rain Water
///     </a>
/// </summary>
public class Solution
{
    public int Trap(int[] height)
    {
        int n = height.Length;
        int[] leftMaxHeights = new int[n];
        int[] rightMaxHeights = new int[n];
        int maxLeftHeight = 0;
        int maxRightHeight = 0;
        for (int i = 0; i < n; ++i)
        {
            int leftHeight = height[i];
            leftMaxHeights[i] = leftHeight >= maxLeftHeight ? 0 : maxLeftHeight;
            maxLeftHeight = Math.Max(maxLeftHeight, leftHeight);

            int rightHeight = height[^(i + 1)];
            rightMaxHeights[^(i + 1)] = rightHeight >= maxRightHeight ? 0 : maxRightHeight;
            maxRightHeight = Math.Max(maxRightHeight, rightHeight);
        }

        int sum = 0;
        for (int i = 0; i < height.Length; i++)
        {
            int maxHeight = Math.Min(leftMaxHeights[i], rightMaxHeights[i]);
            sum += Math.Max(0, maxHeight - height[i]);
        }

        return sum;
    }
}