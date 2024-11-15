namespace source._3200._3239;

/// <summary>
///     <a href="https://leetcode.cn/problems/minimum-number-of-flips-to-make-binary-grid-palindromic-i">
///         Minimum Number os Flips to Make Binary Grid Palindromic I
///     </a>
/// </summary>
public class Solution
{
    public int MinFlips(int[][] grid)
    {
        int rowFlipCount = grid.Sum(FlipCount);

        int colFlipCount = 0;
        int n = grid[0].Length;
        for (int i = 0; i < n; ++i)
        {
            int[] col = grid.Select(row => row[i]).ToArray();
            colFlipCount += FlipCount(col);
        }

        return Math.Min(rowFlipCount, colFlipCount);
    }

    private int FlipCount(int[] line)
    {
        int n = line.Length;
        int count = 0;
        for (int i = 0, j = n - 1; i < j; ++i, --j)
        {
            if (line[i] != line[j]) ++count;
        }

        return count;
    }
}