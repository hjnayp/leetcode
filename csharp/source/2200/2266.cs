namespace source._2200._2266;

/// <summary>
///     <a href="https://leetcode.cn/problems/count-number-of-texts">
///         2266. Count Number of Texts
///     </a>
/// </summary>
public class Solution
{
    public int CountTexts(string pressedKeys)
    {
        List<long> dp3 = [1, 1, 2, 4];
        List<long> dp4 = [1, 1, 2, 4];
        const int MOD = 1_000_000_007;
        int n = pressedKeys.Length;
        for (int i = 4; i <= n; ++i)
        {
            dp3.Add((dp3[i - 1] + dp3[i - 2] + dp3[i - 3]) % MOD);
            dp4.Add((dp4[i - 1] + dp4[i - 2] + dp4[i - 3] + dp4[i - 4]) % MOD);
        }

        long res = 1;
        int cnt = 1;
        for (int i = 1; i < n; ++i)
        {
            if (pressedKeys[i] == pressedKeys[i - 1])
            {
                ++cnt;
            }
            else
            {
                res = res * GetDpCount(pressedKeys[i - 1], cnt) % MOD;
                cnt = 1;
            }
        }

        if (cnt > 1)
        {
            res = res * GetDpCount(pressedKeys[n - 1], cnt) % MOD;
        }

        return (int)res;

        long GetDpCount(char ch, int count)
        {
            return ch switch
            {
                '7' or '9' => dp4[count],
                '2' or '3' or '4' or '5' or '6' or '8' => dp3[count],
                _ => 1,
            };
        }
    }
}