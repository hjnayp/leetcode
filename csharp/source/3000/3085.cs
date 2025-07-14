namespace source._3000._3085;

/// <summary>
///     <a href="https://leetcode.cn/problems/minimum-deletions-to-make-string-k-special">
///         3085. Minimum Deletions to Make String K-Special
///     </a>
/// </summary>
public class Solution
{
    public int MinimumDeletions(string word, int k)
    {
        List<int> freq = Enumerable.Repeat(0, 26).ToList();

        foreach (char c in word)
        {
            freq[c - 'a']++;
        }

        freq = freq.FindAll(value => value > 0);
        freq.Sort();

        int[] sums = new int[freq.Count + 1];
        for (int i = 1; i <= freq.Count; i++)
        {
            sums[i] = freq[i - 1] + sums[i - 1];
        }

        int preSum = 0;
        int res = word.Length;
        int l = 0;
        int r = 0;
        while (r < freq.Count)
        {
            while (r < freq.Count && freq[r] - freq[l] <= k)
            {
                ++r;
            }

            int count = preSum + sums[^1] - sums[r] - (freq[l] + k) * (freq.Count - r);
            res = Math.Min(res, count);
            preSum += freq[l];
            ++l;
        }

        return res;
    }
}