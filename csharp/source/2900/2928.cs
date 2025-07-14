namespace source._2900._2928;

public class Solution
{
    public int DistributeCandies(int n, int limit)
    {
        return Cal(n + 2) - 3 * Cal(n - limit + 1) + 3 * Cal(n - (limit + 1) * 2 + 2)
            - Cal(n - 3 * (limit + 1) + 2);
    }

    private int Cal(int x)
    {
        return x < 0 ? 0 : x * (x - 1) / 2;
    }
}