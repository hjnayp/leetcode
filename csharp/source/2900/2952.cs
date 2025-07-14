namespace source._2900._2952;

public class Solution
{
    public int MinimumAddedCoins(int[] coins, int target)
    {
        Array.Sort(coins);
        int x = 1;
        int idx = 0;
        int len = coins.Length;
        int addedCnt = 0;
        while (x <= target)
        {
            if (idx < len && coins[idx] <= x)
            {
                x += coins[idx];
                ++idx;
            }
            else
            {
                x *= 2;
                ++addedCnt;
            }
        }

        return addedCnt;
    }
}