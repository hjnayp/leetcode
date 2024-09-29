namespace source._2000._2073;

/// <summary>
///     <a href="https://leetcode.cn/problems/time-needed-to-buy-tickets">
///         Time Needed to Buy Tickets
///     </a>
/// </summary>
public class Solution
{
    public int TimeRequiredToBuy(int[] tickets, int k)
    {
        return tickets
            .Select((v, i) => Math.Min(v, tickets[k] - (i <= k ? 0 : 1)))
            .Sum();
    }
}