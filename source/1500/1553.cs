namespace source._1500._1553;

public class Solution
{
    private static Dictionary<int, int> s_memo = new();

    public int MinDays(int n)
    {
        if (s_memo.TryGetValue(n, out int res))
            return res;
        return s_memo[n] = n <= 1
            ? n
            : Math.Min(n % 2 + 1 + MinDays(n / 2), n % 3 + 1 + MinDays(n / 3));
    }
}