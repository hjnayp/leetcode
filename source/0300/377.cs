namespace source._0300._377;

public class Solution
{
    public int CombinationSum4(int[] nums, int target)
    {
        var dp = new int[target + 1];
        dp[0] = 1;

        for (var i = 1; i <= target; ++i)
            foreach (int num in nums)
            {
                if (num > i) continue;
                dp[i] += dp[i - num];
            }

        return dp[target];
    }
}