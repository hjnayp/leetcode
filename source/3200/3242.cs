namespace source._3200._3242;

/// <summary>
///     <a href="https://leetcode.cn/problems/design-neighbor-sum-service">
///         3242. Design Neighbor Sum Service
///     </a>
/// </summary>
public class NeighborSum
{
    private static readonly int[][][] Neighbors =
    [
        [[1, 0], [-1, 0], [0, 1], [0, -1]],
        [[-1, -1], [-1, 1], [1, -1], [1, 1]],
    ];

    private readonly Dictionary<int, int> valueToIndex_ = new();
    private readonly int[][] grid_;
    private readonly int m_;
    private readonly int n_;

    public NeighborSum(int[][] grid)
    {
        grid_ = grid;

        m_ = grid.Length;
        n_ = grid[0].Length;
        for (int i = 0; i < m_; i++)
        {
            int[] row = grid_[i];
            for (int j = 0; j < n_; j++)
            {
                int value = row[j];
                valueToIndex_.Add(value, i * n_ + j);
            }
        }
    }

    public int AdjacentSum(int value)
    {
        return GetSum(0, value);
    }

    public int DiagonalSum(int value)
    {
        return GetSum(1, value);
    }

    private int GetSum(int type, int value)
    {
        int[][] directions = Neighbors[type];

        int row = value / n_;
        int col = value % n_;

        return (from direction in directions
                let i = row + direction[0]
                let j = col + direction[1]
                where i >= 0 && i < m_ && j >= 0 && j < m_
                select grid_[i][j]).Sum();
    }
}