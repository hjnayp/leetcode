using System.Text;

namespace source._3300._3304;

public class Solution
{
    private static string s_words = "a";

    private static void InitWord()
    {
        StringBuilder sb = new(s_words);
        while (sb.Length < 500)
        {
            int len = sb.Length;
            for (int i = 0; i < len; ++i)
            {
                sb.Append(GetNextChar(sb[i]));
            }
        }

        s_words = sb.ToString();
    }

    public char KthCharacter(int k)
    {
        if (s_words.Length < 500) InitWord();
        return s_words[k - 1];
    }

    private static char GetNextChar(char ch)
    {
        if (ch is 'z')
        {
            return 'a';
        }

        return (char)(ch + 1);
    }
}