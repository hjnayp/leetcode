namespace source._0000._59;

/// <summary>
///     <a href="https://leetcode.cn/problems/spiral-matrix-ii">
///         59. Spiral Matrix II
///     </a>
/// </summary>
public class Solution
{
    private static readonly int[][] s_directions = [[0, 1], [1, 0], [0, -1], [-1, 0]];

    public int[][] GenerateMatrix(int n)
    {
        if (n == 1) return [[1]];

        int[][] matrix = new int[n][];
        for (int i = 0; i < matrix.Length; i++) matrix[i] = new int[n];

        int target = n * n;

        int x = 0;
        int y = 0;
        int num = 1;
        int dirIndex = 0;
        while (num <= target)
        {
            matrix[x][y] = num++;

            int nextX = x + s_directions[dirIndex][0];
            int nextY = y + s_directions[dirIndex][1];
            if (nextX < 0 || nextX >= n || nextY < 0 || nextY >= n || matrix[nextX][nextY] != 0)
            {
                dirIndex = (dirIndex + 1) % 4;
            }

            x += s_directions[dirIndex][0];
            y += s_directions[dirIndex][1];
        }

        return matrix;
    }
}