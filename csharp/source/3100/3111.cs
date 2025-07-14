namespace source._3100._3111;

/// <summary>
///     https://leetcode.cn/problems/minimum-rectangles-to-cover-points
/// </summary>
public class Solution
{
    public int MinRectanglesToCoverPoints(int[][] points, int w)
    {
        Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));
        int rectangleCount = 0;
        int bound = -1;
        foreach (int[] point in points)
        {
            if (point[0] <= bound) continue;
            
            bound = point[0] + w;
            ++rectangleCount;
        }

        return rectangleCount;
    }
}