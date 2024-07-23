namespace source._3000._3098;

public class Solution
{
    private const int MOD = 1000000007;
    private const int INF = 0x3f3f3f3f;

    public int SumOfPowers(int[] nums, int k)
    {
        int n = nums.Length;
        int powerSum = 0;
        var countBy_EndAt_Len_Power = new IDictionary<int, int>[n][];
        for (int i = 0; i < n; i++)
        {
            countBy_EndAt_Len_Power[i] = new IDictionary<int, int>[k + 1];
            for (int j = 0; j <= k; j++)
            {
                countBy_EndAt_Len_Power[i][j] = new Dictionary<int, int>();
            }
        }

        Array.Sort(nums);
        for (int i = 0; i < n; i++)
        {
            countBy_EndAt_Len_Power[i][1].Add(INF, 1);
            for (int j = 0; j < i; j++)
            {
                int diff = Math.Abs(nums[i] - nums[j]);
                for (int p = 2; p <= k; p++)
                {
                    foreach ((int v, int cnt) in countBy_EndAt_Len_Power[j][p - 1])
                    {
                        int currKey = Math.Min(diff, v);
                        countBy_EndAt_Len_Power[i][p].TryAdd(currKey, 0);
                        countBy_EndAt_Len_Power[i][p][currKey] = (countBy_EndAt_Len_Power[i][p][currKey] + cnt) % MOD;
                    }
                }
            }

            foreach ((int v, int cnt) in countBy_EndAt_Len_Power[i][k])
            {
                powerSum = (int)((powerSum + 1L * v * cnt % MOD) % MOD);
            }
        }

        return powerSum;
    }
}