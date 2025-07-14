namespace source._3100._3148;

public class Solution
{
    public int MaxScore(IList<IList<int>> grid)
    {
        int m = grid.Count;
        int n = grid[0].Count;

        int maxScore = int.MinValue;
        int[] columnMaxValue = new int[n];
        Array.Fill(columnMaxValue, int.MinValue);
        for (int i = 0; i < m; ++i)
        {
            int rowMaxValue = int.MinValue;
            for (int j = 0; j < n; ++j)
            {
                int score = int.MinValue;

                if (i > 0)
                {
                    score = Math.Max(score, columnMaxValue[j] + grid[i][j]);
                }

                if (j > 0)
                {
                    score = Math.Max(score, rowMaxValue + grid[i][j]);
                }

                maxScore = Math.Max(maxScore, score);
                score = Math.Max(0, score);
                rowMaxValue = Math.Max(rowMaxValue, score - grid[i][j]);
                columnMaxValue[j] = Math.Max(columnMaxValue[j], score - grid[i][j]);
            }
        }

        return maxScore;
    }
}