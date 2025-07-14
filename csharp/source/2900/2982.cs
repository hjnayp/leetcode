namespace source._2900._2982;

public class Solution
{
    public int MaximumLength(string s)
    {
        int len = s.Length;
        int[,] chs = new int[26, 3];


        int j = 0;
        for (int i = 0; i < len; i = j)
        {
            while (j < len && s[i] == s[j]) ++j;

            int cnt = j - i;
            int idx = s[i] - 'a';

            if (cnt > chs[idx, 0])
            {
                chs[idx, 2] = chs[idx, 1];
                chs[idx, 1] = chs[idx, 0];
                chs[idx, 0] = cnt;
            }
            else if (cnt > chs[idx, 1])
            {
                chs[idx, 2] = chs[idx, 1];
                chs[idx, 1] = cnt;
            }
            else if (cnt > chs[idx, 2])
            {
                chs[idx, 2] = cnt;
            }
        }

        int res = 0;
        for (int i = 0; i < 26; ++i)
        {
            res = Math.Max(res, chs[i, 0] - 2);
            res = Math.Max(res, Math.Min(chs[i, 0] - 1, chs[i, 1]));
            res = Math.Max(res, chs[i, 2]);
        }

        return res > 0 ? res : -1;
    }
}