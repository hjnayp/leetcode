namespace source._2500._2575;

public class Solution
{
    public int[] DivisibilityArray(string word, int m)
    {
        int n = word.Length;
        var res = new int[n];
        long cur = 0;
        for (var i = 0; i < n; ++i)
        {
            cur = cur * 10 + word[i] - '0';
            cur %= m;
            res[i] = cur == 0 ? 1 : 0;
        }

        return res;
    }
}