namespace source._3100._3137;

/// <summary>
///     https://leetcode.cn/problems/minimum-number-of-operations-to-make-word-k-periodic
/// </summary>
public class Solution
{
    public int MinimumOperationsToMakeKPeriodic(string word, int k)
    {
        IDictionary<string, int> wordToCount = new Dictionary<string, int>();
        int maxWordCount = 0;
        for (int i = 0; i < word.Length; i += k)
        {
            string w = word.Substring(i, k);
            wordToCount.TryAdd(w, 0);
            wordToCount[w] += 1;
            maxWordCount = Math.Max(maxWordCount, wordToCount[w]);
        }

        return word.Length / k - maxWordCount;
    }
}