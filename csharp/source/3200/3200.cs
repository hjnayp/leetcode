namespace source._3200._3200;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximum-height-of-a-triangle">
///         Maximum Height of a Triangle
///     </a>
/// </summary>
public class Solution
{
    public int MaxHeightOfTriangle(int red, int blue)
    {
        return Math.Max(MaxHeight(red, blue), MaxHeight(blue, red));
    }

    public int MaxHeight(int x, int y)
    {
        int odd = 2 * (int)Math.Sqrt(x) - 1;
        int even = 2 * (int)((-1 + Math.Sqrt(1 + 4 * y)) / 2);
        return Math.Min(odd, even) + 1;
    }
}