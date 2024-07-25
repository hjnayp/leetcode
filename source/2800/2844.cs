namespace source._2800._2844;

/// <summary>
///     https://leetcode.cn/problems/minimum-operations-to-make-a-special-number
/// </summary>
public class Solution
{
    public int MinimumOperations(string num)
    {
        var showedChars = new HashSet<char>();

        for (int i = 1; i <= num.Length; i++)
        {
            char curCh = num[^i];
            switch (curCh)
            {
                case '0' when showedChars.Contains('0'): return i - 2;
                case '2' when showedChars.Contains('5'): return i - 2;
                case '5' when showedChars.Contains('0'): return i - 2;
                case '7' when showedChars.Contains('5'): return i - 2;
            }

            showedChars.Add(curCh);
        }

        return showedChars.Contains('0') ? num.Length - 1 : num.Length;
    }
}