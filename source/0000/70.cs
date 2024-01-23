namespace source._0000._70;

public class Solution
{
    private static readonly List<int> _cache = new() { 0, 1, 2 };

    public int ClimbStairs(int n)
    {
        if (n < _cache.Count)
            return _cache[n];

        for (var i = _cache.Count; i <= n; ++i)
            _cache.Add(_cache[i - 1] + _cache[i - 2]);

        return _cache[n];
    }
}