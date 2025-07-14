namespace source._1800._1844;

public class Solution
{
    public string ReplaceDigits(string s)
    {
        char[] chars = s.ToCharArray();
        for (int i = 1; i < s.Length; i += 2)
        {
            chars[i] = ShiftChar(s[i - 1], s[i] - '0');
        }

        return new string(chars);
    }

    private char ShiftChar(char ch, int offset)
    {
        return (char)(ch + offset);
    }
}