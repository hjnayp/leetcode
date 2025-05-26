namespace source._3000._3068;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-the-maximum-sum-of-node-values">
///         3068. Find the Maximum Sum of Node Values
///     </a>
/// </summary>
public class Solution
{
    public long MaximumValueSum(int[] nums, int k, int[][] edges)
    {
        long res = nums.Sum(x => (long)x);
        List<int> diffs = nums.Select((x) => (x ^ k) - x).ToList();
        diffs.Sort();
        for (int i = diffs.Count - 1; i > 0 && diffs[i] + diffs[i - 1] > 0; i -= 2)
        {
            res += diffs[i] + diffs[i - 1];
        }

        return res;
    }
}