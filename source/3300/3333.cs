namespace source._3300._3333;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-the-original-typed-string-ii">
///         3333. Find the Original Typed String II
///     </a>
/// </summary>
public class Solution
{
    private const int MOD = 1_000_000_007;

    public int PossibleStringCount(string word, int k)
    {
        List<int> freq = [];
        int cnt = 1;
        for (int i = 1; i < word.Length; ++i)
        {
            if (word[i] == word[i - 1])
            {
                ++cnt;
            }
            else
            {
                freq.Add(cnt);
                cnt = 1;
            }
        }

        freq.Add(cnt);

        long ans = freq.Aggregate<int, long>(1, (current, f) => current * f % MOD); // All length count
        if (freq.Count >= k) return (int)ans;

        int[] g = new int[k]; // g(i) is the sum for length from 0 to k-1
        Array.Fill(g, 1);

        foreach (int chCnt in freq)
        {
            int[] f = new int[k]; // f(j) is the count of length j str
            for (int j = 1; j < k; ++j)
            {
                f[j] = g[j - 1];
                var start = j - chCnt - 1;
                if (start >= 0)
                {
                    f[j] = (f[j] - g[start] + MOD) % MOD;
                }
            }

            int[] gNew = new int[k];
            gNew[0] = f[0];
            for (int j = 1; j < k; ++j)
            {
                gNew[j] = (f[j] + gNew[j - 1]) % MOD;
            }

            g = gNew;
        }

        return (int)((ans - g[k - 1] + MOD) % MOD);
    }
}