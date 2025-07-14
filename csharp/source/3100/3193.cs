namespace source._3100._3193;

/// <summary>
///     <a href="https://leetcode.cn/problems/count-the-number-of-inversions">
///         Count the Number of Inversions
///     </a>
/// </summary>
public class Solution
{
    private const int Mod = 1000000007;
    private readonly IDictionary<int, long> _endToRequirementNum = new Dictionary<int, long> { { 0, 0 } };
    private long[][] _dp = [];

    public int NumberOfPermutations(int n, int[][] requirements)
    {
        int maxCnt = 0;
        foreach (int[] req in requirements)
        {
            _endToRequirementNum[req[0]] = req[1];
            maxCnt = Math.Max(maxCnt, req[1]);
        }

        if (_endToRequirementNum[0] != 0) return 0;

        _dp = new long[n][];
        for (int i = 0; i < n; i++)
        {
            _dp[i] = new long[maxCnt + 1];
            Array.Fill(_dp[i], -1);
        }

        return (int)Dfs(n - 1, _endToRequirementNum[n - 1]);
    }

    private long Dfs(int end, long cnt)
    {
        if (cnt < 0) return 0;
        if (end == 0) return 1;
        if (_dp[end][cnt] != -1) return _dp[end][cnt];

        if (_endToRequirementNum.ContainsKey(end - 1))
        {
            long prevReqCnt = _endToRequirementNum[end - 1];
            if (prevReqCnt <= cnt && cnt <= end + prevReqCnt)
            {
                return _dp[end][cnt] = Dfs(end - 1, prevReqCnt);
            }

            return 0;
        }

        if (cnt > end)
        {
            return _dp[end][cnt]
                = (Dfs(end, cnt - 1)
                    - Dfs(end - 1, cnt - 1 - end)
                    + Dfs(end - 1, cnt)
                    + Mod) % Mod;
        }

        return _dp[end][cnt] = (Dfs(end, cnt - 1) + Dfs(end - 1, cnt)) % Mod;
    }
}