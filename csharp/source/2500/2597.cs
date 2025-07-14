namespace source._2500._2597;

/// <summary>
///     <a href="https://leetcode.cn/problems/the-number-of-beautiful-subsets">
///         2597. The Number of Beautiful Subsets
///     </a>
/// </summary>
public class Solution
{
    public int BeautifulSubsets(int[] nums, int k)
    {
        var modToNumToCount = new Dictionary<int, SortedDictionary<int, int>>();
        foreach (int num in nums)
        {
            int mod = num % k;
            modToNumToCount.TryAdd(mod, new SortedDictionary<int, int>());
            modToNumToCount[mod][num] = modToNumToCount[mod].GetValueOrDefault(num, 0) + 1;
        }

        int res = 1;
        foreach (SortedDictionary<int, int> numToCount in modToNumToCount.Values)
        {
            int n = numToCount.Count;
            int[,] f = new int[n, 2];
            f[0, 0] = 1;
            f[0, 1] = (1 << numToCount.First().Value) - 1;

            int idx = 1;
            KeyValuePair<int, int> prev = numToCount.First();
            foreach (KeyValuePair<int, int> curr in numToCount.Skip(1))
            {
                f[idx, 0] = f[idx - 1, 0] + f[idx - 1, 1];
                f[idx, 1] = f[idx - 1, 1] + (1 << prev.Value) - 1;
                if (curr.Key - prev.Key == k)
                {
                    f[idx, 1] = f[idx - 1, 0] * ((1 << curr.Value) - 1);
                }
                else
                {
                    f[idx, 1] = (f[idx - 1, 0] + f[idx - 1, 1]) * ((1 << curr.Value) - 1);
                }

                prev = curr;
                ++idx;
            }

            res *= f[n - 1, 0] + f[n - 1, 1];
        }

        return res - 1;
    }
}