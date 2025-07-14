namespace source._2500._2580;

public class Solution
{
    public int CountWays(int[][] ranges)
    {
        const int MOD = (int)(1e9 + 7);
        Array.Sort(ranges, (a, b) => a[0] - b[0]);

        int n = ranges.Length;
        long res = 1;
        for (var i = 0; i < n;)
        {
            int right = ranges[i][1];
            int j = i + 1;
            while (j < n && ranges[j][0] <= right)
            {
                right = Math.Max(right, ranges[j][1]);
                ++j;
            }

            res = res * 2 % MOD;
            i = j;
        }

        return (int)res;
    }
}