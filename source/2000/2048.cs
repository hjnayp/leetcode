namespace source._2000._2048;

public class Solution
{
    public int NextBeautifulNumber(int n)
    {
        for (var i = n + 1; i < 1e7; ++i)
            if (IsBeautiful(i))
                return i;

        return -1;
    }

    private static bool IsBeautiful(int n)
    {
        var count = new Dictionary<int, int>();
        while (n > 0)
        {
            var digit = n % 10;
            count.TryAdd(digit, 0);
            ++count[digit];
            n /= 10;
        }

        return count.All(kv => kv.Key == kv.Value);
    }
}