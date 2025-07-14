namespace source._0000._28;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-the-index-of-the-first-occurrence-in-a-string">
///         Find the Index of the First Occurrence in a String
///     </a>
/// </summary>
public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        int n = needle.Length;
        int[] nextCharPosition = GenerateKmpArray(needle);
        int idx = 0;
        for (int i = 0; i < haystack.Length; i++)
        {
            while (haystack[i] != needle[idx] && idx > 0)
            {
                idx = nextCharPosition[idx - 1];
            }

            if (haystack[i] != needle[idx]) continue;

            if (++idx == n)
            {
                return i - n + 1;
            }
        }

        return -1;
    }

    private int[] GenerateKmpArray(string str)
    {
        int n = str.Length;
        int[] kmp = new int[n];
        kmp[0] = 0;
        int j = 0;
        for (int i = 1; i < n; i++)
        {
            while (str[i] != str[j] && j > 0)
            {
                j = kmp[j - 1];
            }

            if (str[i] != str[j]) continue;
            kmp[i] = ++j;
        }

        return kmp;
    }
}