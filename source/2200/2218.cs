namespace source._2200._2218;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximum-value-of-k-coins-from-piles">
///         2218. Maximum Value of K Coins From Piles
///     </a>
/// </summary>
public class Solution
{
    public int MaxValueOfCoins(IList<IList<int>> piles, int k)
    {
        int[] maxValues = new int[k + 1];
        Array.Fill(maxValues, -1);
        maxValues[0] = 0;

        foreach (IList<int> pile in piles)
        {
            for (int i = k; i > 0; --i)
            {
                int value = 0;
                for (int j = 1; j <= pile.Count; j++)
                {
                    value += pile[j - 1];
                    if (i >= j && maxValues[i - j] != -1)
                    {
                        maxValues[i] = Math.Max(maxValues[i], maxValues[i - j] + value);
                    }
                }
            }
        }

        return maxValues[k];
    }
}