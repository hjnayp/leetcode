namespace source._1500._1561;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximum-number-of-coins-you-can-get">
///         1561. Maximum Number of Coins You Can Get
///     </a>
/// </summary>
public class Solution
{
    public int MaxCoins(int[] piles)
    {
        Array.Sort(piles);
        int res = 0;
        int len = piles.Length / 3;
        for (int i = 0; i < len; ++i)
        {
            res += piles[^(i * 2 + 2)];
        }

        return res;
    }
}