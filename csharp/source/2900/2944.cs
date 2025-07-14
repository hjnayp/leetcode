namespace source._2900._2944;

/// <summary>
///     <a href="https://leetcode.cn/problems/minimum-number-of-coins-for-fruits">
///         2944. Minimum Number of Coins for Fruits
///     </a>
/// </summary>
public class Solution
{
    public int MinimumCoins(int[] prices)
    {
        var minCosts = new LinkedList<(int, int)>();
        minCosts.AddFirst((prices.Length, 0));

        for (int i = prices.Length - 1; i >= 0; i--)
        {
            while (minCosts.Last.Value.Item1 >= i * 2 + 3)
            {
                minCosts.RemoveLast();
            }

            var cost = minCosts.Last.Value.Item2 + prices[i];
            while (cost <= minCosts.First.Value.Item2)
            {
                minCosts.RemoveFirst();
            }

            minCosts.AddFirst((i, cost));
        }

        return minCosts.First.Value.Item2;
    }
}