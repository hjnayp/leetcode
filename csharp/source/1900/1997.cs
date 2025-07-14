namespace source._1900._1997;

public class Solution
{
    public int FirstDayBeenInAllRooms(int[] nextVisit)
    {
        const int MOD = (int)(1e9 + 7);
        int len = nextVisit.Length;
        var dp = new int[len];
        dp[0] = 2;
        for (var i = 1; i < len; ++i)
        {
            int to = nextVisit[i];
            dp[i] = 2 + dp[i - 1];
            if (to != 0)
                dp[i] = (dp[i] - dp[to - 1] + MOD) % MOD;

            dp[i] = (dp[i] + dp[i - 1]) % MOD;
        }

        return dp[len - 2];
    }
}