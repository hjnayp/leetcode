namespace source._1600._1690;

public class Solution
{
    public int StoneGameVII(int[] stones)
    {
        int n = stones.Length;
        var sum = new int[n + 1];
        var memory = new Dictionary<int, IList<int>>();
        for (var i = 0; i < n; ++i)
        {
            sum[i + 1] = sum[i] + stones[i];
            memory[i] = new int[n];
        }

        return Dfs(0, n - 1);

        int Dfs(int i, int j)
        {
            if (i >= j)
                return 0;

            if (memory is null)
                throw new NullReferenceException("memory is null");

            if (memory[i][j] > 0)
                return memory[i][j];

            int result = Math.Max(sum[j] - sum[i] - Dfs(i, j - 1),
                                  sum[j + 1] - sum[i + 1] - Dfs(i + 1, j));
            memory[i][j] = result;
            return result;
        }
    }
}