namespace source._3100._3180;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximum-total-reward-using-operations-i">
///         Maximum Total Reward Using Operations I
///     </a>
/// </summary>
public class Solution
{
    public int MaxTotalReward(int[] rewardValues)
    {
        Array.Sort(rewardValues);
        int max = rewardValues[^1];
        bool[] dp = new bool[2 * max];
        dp[0] = true;

        foreach (int rewardValue in rewardValues)
        {
            for (int i = 2 * rewardValue - 1; i >= rewardValue; --i)
            {
                if (dp[i - rewardValue])
                {
                    dp[i] = true;
                }
            }
        }

        int res = 0;
        for (int i = 2 * max - 1; i >= 0; --i)
        {
            if (!dp[i]) continue;
            res = i;
            break;
        }

        return res;
    }
}