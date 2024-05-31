namespace source._2900._2965;

public class Solution
{
    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {
        int n = grid.Length;
        int[] cnts = new int[n * n];
        foreach (int[] row in grid)
        {
            foreach (int i in row)
            {
                ++cnts[i - 1];
            }
        }

        int missing = 0;
        int repeated = 0;
        for (int i = 0; i < cnts.Length; i++)
        {
            if (cnts[i] == 2) repeated = i + 1;
            if (cnts[i] == 0) missing = i + 1;
        }

        return new[] { repeated, missing };
    }
}