namespace source._3100._3143;

/// <summary>
///     https://leetcode.cn/problems/maximum-points-inside-the-square
/// </summary>
public class Solution
{
    private const int MaxSideLength = (int)1e9 + 1;

    public int MaxPointsInsideSquare(int[][] points, string s)
    {
        int[] tagMaxDistances = new int[26];
        Array.Fill(tagMaxDistances, MaxSideLength);
        int minDistance = MaxSideLength;
        for (int i = 0; i < points.Length; i++)
        {
            int x = points[i][0];
            int y = points[i][1];
            int tag = s[i] - 'a';
            int distance = Math.Max(Math.Abs(x), Math.Abs(y));
            if (distance < tagMaxDistances[tag])
            {
                minDistance = Math.Min(minDistance, tagMaxDistances[tag]);
                tagMaxDistances[tag] = distance;
            }
            else if (distance < minDistance)
            {
                minDistance = distance;
            }
        }

        return tagMaxDistances.Count(distance => distance < minDistance);
    }
}