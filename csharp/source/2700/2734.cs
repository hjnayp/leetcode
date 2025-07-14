namespace source._2700._2734;

public class Solution
{
    public string SmallestString(string s)
    {
        int n = s.Length;
        bool isChanged = false;
        char[] chs = s.ToCharArray();
        for (int i = 0; i < chs.Length; i++)
        {
            char ch = chs[i];
            if (ch == 'a')
            {
                if (isChanged) break;

                if (i == n - 1)
                {
                    chs[i] = 'z';
                    break;
                }

                continue;
            }

            chs[i] = (char)(ch - 1);
            if (!isChanged)
            {
                isChanged = true;
            }
        }

        return new string(chs);
    }
}