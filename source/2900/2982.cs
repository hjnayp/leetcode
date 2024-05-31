namespace source._2900._2982;

public class Solution
{
    public int MaximumLength(string s)
    {
        int len = s.Length;
        var chs = new List<int>[26];
        for (int i = 0; i < 26; ++i) chs[i] = new List<int>();

        int cnt = 0;
        for (int i = 0; i < len; ++i)
        {
            ++cnt;
            if (i + 1 != len && s[i] == s[i + 1]) continue;

            int c = s[i] - 'a';
            chs[c].Add(cnt);
            cnt = 0;
            for (int j = chs[c].Count - 1; j > 0; --j)
            {
                if (chs[c][j] <= chs[c][j - 1]) break;
                (chs[c][j], chs[c][j - 1]) = (chs[c][j - 1], chs[c][j]);
            }

            if (chs[c].Count > 3) chs[c].RemoveAt(3);
        }

        int res = -1;
        foreach (List<int> chCntArr in chs)
        {
            if (chCntArr.Count > 0 && chCntArr[0] > 2) res = Math.Max(res, chCntArr[0] - 2);
            if (chCntArr.Count > 1 && chCntArr[0] > 1) res = Math.Max(res, Math.Min(chCntArr[0] - 1, chCntArr[1]));
            if (chCntArr.Count > 2) res = Math.Max(res, chCntArr[2]);
        }

        return res;
    }
}