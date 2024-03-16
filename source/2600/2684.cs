namespace source._2600._2684;

public class Solution
{
    public int MaxMoves(int[][] grid)
    {
        var res = 0;
        int m = grid.Length;
        int n = grid[0].Length;

        var visited = new bool[m, n];
        for (var i = 0; i < m; ++i)
        for (var j = 0; j < n; ++j)
            visited[i, j] = false;

        for (var i = 0; i < m; ++i)
            Dfs(i, 0);
        return res;

        void Dfs(int row, int col)
        {
            if (visited[row, col]) return;
            visited[row, col] = true;
            if (col > res)
                res = col;

            if (col + 1 >= n) return;
            for (int i = -1; i <= 1; ++i)
            {
                if (row + i < 0 || row + i >= m) continue;
                if (grid[row + i][col + 1] > grid[row][col])
                    Dfs(row + i, col + 1);
            }
        }
    }
}