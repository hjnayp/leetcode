namespace source._0500._522;

public class Solution
{
    public int FindLUSlength(string[] strs)
    {
        Array.Sort(strs, (a, b) => b.Length - a.Length);
        IList<List<string>> strsList = new List<List<string>>();

        int len = 0;
        foreach (string str in strs)
        {
            if (str.Length != len)
            {
                strsList.Add(new List<string>());
                len = str.Length;
            }

            strsList[^1].Add(str);
        }

        for (int i = 0; i < strsList.Count; i++)
        {
            IList<string> nowStrs = strsList[i];
            IDictionary<string, int> strToOccurCnt = new Dictionary<string, int>();
            foreach (string str in nowStrs)
            {
                if (!strToOccurCnt.TryAdd(str, 1)) strToOccurCnt[str]++;
            }

            nowStrs = nowStrs.Where((str) => strToOccurCnt[str] == 1).ToList();

            IList<string>? parentStrs = i > 0 ? strsList[i - 1] : null;
            if (parentStrs is not null)
            {
                nowStrs = nowStrs.Where((s) => parentStrs.All(parentStr => !IsSubSequence(parentStr, s)))
                    .ToList();
            }

            if (nowStrs.Count > 0) return nowStrs[0].Length;
        }


        return -1;

        bool IsSubSequence(string parentStr, string subStr)
        {
            int lenDifference = parentStr.Length - subStr.Length;
            if (lenDifference < 0) return false;

            int i = 0;
            int j = 0;
            while (i < parentStr.Length && j < subStr.Length)
            {
                if (parentStr[i] == subStr[j]) j++;
                i++;
                if (i - j > lenDifference) return false;
            }

            return j == subStr.Length;
        }
    }
}