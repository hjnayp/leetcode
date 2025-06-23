// #回文 #回文生成

using System.Text;

namespace source._2000;

/// <summary>
///     <see href="https://leetcode.cn/problems/sum-of-k-mirror-numbers">
///         2081. Sum of k-Mirror Numbers
///     </see>
/// </summary>
public class Solution
{
    public long KMirror(int k, int n)
    {
        int left = 1;
        int count = 0;
        long ans = 0;
        while (count < n)
        {
            int right = left * 10;
            // op = 0 表示枚举奇数长度回文，op = 1 表示枚举偶数长度回文
            for (int op = 0; op < 2; ++op)
            {
                // 枚举 i'
                for (int i = left; i < right && count < n; ++i)
                {
                    long combined = i;
                    int x = op == 0 ? i / 10 : i;
                    while (x > 0)
                    {
                        combined = combined * 10 + x % 10;
                        x /= 10;
                    }

                    if (!IsMirror(ConvertToKBase(combined, k))) continue;
                    ++count;
                    ans += combined;
                }
            }

            left = right;
        }

        return ans;
    }

    private static string ConvertToKBase(long number, int k)
    {
        string characters = "0123456789";
        var result = new StringBuilder();

        long num = Math.Abs(number); // 转换绝对值
        while (num > 0)
        {
            int remainder = (int)(num % k);
            result.Append(characters[remainder]);
            num /= k;
        }

        return new string(result.ToString().Reverse().ToArray());
    }

    private static bool IsMirror(string s)
    {
        int l = 0;
        int r = s.Length - 1;
        while (l < r)
        {
            if (s[l++] != s[r--])
            {
                return false;
            }
        }

        return true;
    }
}