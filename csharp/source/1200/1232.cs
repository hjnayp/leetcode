namespace source._1200._1232;

/// <summary>
///     <a href="https://leetcode.cn/problems/check-if-it-is-a-straight-line/description/">
///         1232. Check If It Is a Straight Line
///     </a>
/// </summary>
public class Solution
{
    public bool CheckStraightLine(int[][] coordinates)
    {
        int deltaX = coordinates[0][0];
        int deltaY = coordinates[0][1];

        for (int i = 1; i < coordinates.Length; i++)
        {
            coordinates[i][0] -= deltaX;
            coordinates[i][1] -= deltaY;
        }

        int a = coordinates[1][1];
        int b = -coordinates[1][0];
        return coordinates.Skip(2).All(pos =>
        {
            int x = pos[0];
            int y = pos[1];
            return a * x + b * y == 0;
        });
    }
}