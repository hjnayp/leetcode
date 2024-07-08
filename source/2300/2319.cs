namespace source._2300._2319;

public class Solution
{
    public bool CheckXMatrix(int[][] grid)
    {
        int n = grid.Length;
        for (int i = 0; i < grid.Length; i++)
        for (int j = 0; j < grid[i].Length; j++)
        {
            int value = grid[i][j];
            switch (IsDiagonal(i, j))
            {
                case true when value == 0:
                case false when value != 0:
                    return false;
            }
        }

        return true;

        bool IsDiagonal(int i, int j)
        {
            return i == j || i + j == n - 1;
        }
    }
}