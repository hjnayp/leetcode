namespace source._2500._2516;

/// <summary>
///     <a href="https://leetcode.cn/problems/take-k-of-each-character-from-left-and-right">
///         Take K of Each Character From Left and Right
///     </a>
/// </summary>
public class Solution
{
    private class CharCountInfo
    {
        public int A { get; private set; }
        public int B { get; private set; }
        public int C { get; private set; }

        public int Count => A + B + C;

        public void AddChar(char ch)
        {
            if (ch == 'a') ++A;
            if (ch == 'b') ++B;
            if (ch == 'c') ++C;
        }

        public void RemoveChar(char ch)
        {
            if (ch == 'a') --A;
            if (ch == 'b') --B;
            if (ch == 'c') --C;
        }
    }

    public int TakeCharacters(string s, int k)
    {
        if (k == 0) return 0;
        if (k * 3 > s.Length) return -1;

        CharCountInfo leftInfo = new();
        CharCountInfo rightInfo = new();

        foreach (char ch in s)
        {
            leftInfo.AddChar(ch);
            if (IsValid()) break;
        }

        if (!IsValid()) return -1;

        int min = leftInfo.Count;
        int left = leftInfo.Count - 1;
        int right = s.Length - 1;
        while (right >= 0)
        {
            rightInfo.AddChar(s[right]);
            while (IsValid())
            {
                if (left >= 0)
                {
                    leftInfo.RemoveChar(s[left]);
                    --left;
                }
                else
                {
                    break;
                }
            }

            min = Math.Min(min, leftInfo.Count + rightInfo.Count + (IsValid() ? 0 : 1));
            --right;
        }

        return min;

        bool IsValid()
        {
            return leftInfo.A + rightInfo.A >= k
                && leftInfo.B + rightInfo.B >= k
                && leftInfo.C + rightInfo.C >= k;
        }
    }
}