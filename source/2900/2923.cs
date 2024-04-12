namespace source._2900._2923;

/// <summary>
///     https://leetcode.cn/problems/find-champion-i
/// </summary>
public class Solution
{
    public int FindChampion(int[][] grid)
    {
        int n = grid.Length;
        var champion = 0;
        for (var i = 1; i < grid.Length; i++)
            if (grid[champion][i] == 0)
                champion = i;

        return champion;
    }
}