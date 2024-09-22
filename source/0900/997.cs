namespace source._0900._997;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-the-town-judge">
///         Find the Town Judge
///     </a>
/// </summary>
public class Solution
{
    public int FindJudge(int n, int[][] trust)
    {
        IDictionary<int, int[]> idToTrustInfo = new Dictionary<int, int[]>();
        foreach (int[] info in trust)
        {
            int a = info[0];
            int b = info[1];
            idToTrustInfo.TryAdd(a, [0, 0]);
            idToTrustInfo.TryAdd(b, [0, 0]);
            idToTrustInfo[a][0]++;
            idToTrustInfo[b][1]++;
        }

        for (int i = 1; i <= n; ++i)
        {
            if (idToTrustInfo.TryGetValue(i, out int[]? info))
            {
                if (info[0] == 0 &&
                    info[1] == n - 1)
                {
                    return i;
                }
            }
            else if (n == 1)
            {
                return i;
            }
        }

        return -1;
    }
}