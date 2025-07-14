namespace source._2700._2732;

public class Solution
{
    public IList<int> GoodSubsetofBinaryMatrix(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        IList<int> rowIdxs = new List<int>();
        IDictionary<int, int> bitmaskToRowIdx = new Dictionary<int, int>();
        for (int i = 0; i < m; ++i)
        {
            int bitmask = 0;
            for (int j = 0; j < n; ++j)
            {
                bitmask |= grid[i][j] << j;
            }

            bitmaskToRowIdx.TryAdd(bitmask, i);
        }

        if (bitmaskToRowIdx.TryGetValue(0, out int idx))
        {
            rowIdxs.Add(idx);
            return rowIdxs;
        }

        foreach ((int bitmask1, int idx1) in bitmaskToRowIdx)
        foreach ((int bitmask2, int idx2) in bitmaskToRowIdx)
        {
            if ((bitmask1 & bitmask2) != 0) continue;
            rowIdxs.Add(Math.Min(idx1, idx2));
            rowIdxs.Add(Math.Max(idx1, idx2));
            return rowIdxs;
        }

        return rowIdxs;
    }
}