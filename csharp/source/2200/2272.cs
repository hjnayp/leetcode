namespace source._2200;

/// <summary>
///     <a href="https://leetcode.cn/problems/substring-with-largest-variance">
///         2272. Substring With Largest Variance
///     </a>
/// </summary>
public class Solution
{
    public int LargestVariance(string s)
    {
        Dictionary<char, List<int>> chToPoses = new();
        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            chToPoses.TryAdd(ch, []);
            chToPoses[ch].Add(i);
        }

        int variance = 0;

        foreach (KeyValuePair<char, List<int>> chToPos1 in chToPoses)
        foreach (KeyValuePair<char, List<int>> chToPos2 in chToPoses)
        {
            if (chToPos1.Key == chToPos2.Key) continue;

            List<int> pos1 = chToPos1.Value; // max char positions
            List<int> pos2 = chToPos2.Value; // min char positions

            int i = 0, j = 0;
            int f = 0, g = int.MinValue;

            while (i < pos1.Count || j < pos2.Count)
            {
                if (j == pos2.Count || (i < pos1.Count && pos1[i] < pos2[j]))
                {
                    f = Math.Max(0, f) + 1;
                    g += 1;
                    ++i;
                }
                else
                {
                    // Must frist assign g
                    g = Math.Max(f, 0) - 1;
                    f = Math.Max(f, 0) - 1;
                    ++j;
                }

                variance = Math.Max(variance, g);
            }
        }

        return variance;
    }
}