using System.Numerics;

namespace source._0300._306;

/// <summary>
///     <a href="https://leetcode.cn/problems/additive-number/">
///         306. Additive Number
///     </a>
/// </summary>
public class Solution
{
    public bool IsAdditiveNumber(string num)
    {
        return Dfs(num, []);

        bool Dfs(string numStr, IList<BigInteger> path)
        {
            switch (path.Count)
            {
                case >= 3 when path[^1] != path[^2] + path[^3]:
                    return false;

                case >= 3 when numStr == string.Empty:
                    return true;
            }

            for (int i = 1; i < numStr.Length + 1; i++)
            {
                string cur = numStr[..i];
                if (cur.Length > 1 && cur[0] == '0')
                {
                    continue;
                }

                if (Dfs(numStr[i..], [..path, BigInteger.Parse(cur)]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}