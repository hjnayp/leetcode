namespace source._1900._1902;

public class Solution
{
    public int[] FindPeakGrid(int[][] mat)
    {
        var m = mat.Length;
        var n = mat[0].Length;
        var low = 0;
        var high = m - 1;
        while (low <= high)
        {
            var i = low + (high - low) / 2;
            var row = mat[i];
            var max_val = row.Max();
            var j = Array.IndexOf(row, max_val);
            if (i - 1 >= 0 && mat[i][j] < mat[i - 1][j])
                high = i - 1;
            else if (i + 1 < m && mat[i][j] < mat[i + 1][j])
                low = i + 1;
            else
                return new[] { i, j };
        }

        return Array.Empty<int>();
    }
}