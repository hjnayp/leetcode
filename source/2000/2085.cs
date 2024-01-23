namespace source._2000._2085;

public class Solution
{
    public int CountWords(string[] words1, string[] words2)
    {
        var freq_1 = new Dictionary<string, int>();
        var freq_2 = new Dictionary<string, int>();

        foreach (var s in words1)
            freq_1[s] = freq_1.GetValueOrDefault(s, 0) + 1;
        foreach (var s in words2)
            freq_2[s] = freq_2.GetValueOrDefault(s, 0) + 1;

        return freq_1.Where(k => k.Value == 1)
                     .Count(k => freq_2.GetValueOrDefault(k.Key) == 1);
    }
}