using System.Text;

namespace source._0000._14;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string minLengthStr = strs[0];
        string maxLengthStr = strs[0];

        foreach (string str in strs)
        {
            if (str.CompareTo(minLengthStr) < 0)
            {
                minLengthStr = str;
            }

            if (str.CompareTo(maxLengthStr) > 0)
            {
                maxLengthStr = str;
            }
        }

        return CommonPrefix(minLengthStr, maxLengthStr);
    }

    private string CommonPrefix(string str1, string str2)
    {
        StringBuilder sb = new();
        int m = str1.Length;
        int n = str2.Length;

        for (int i = 0; i < Math.Min(m, n); ++i)
        {
            if (str1[i] == str2[i])
            {
                sb.Append(str1[i]);
            }
            else
            {
                break;
            }
        }

        return sb.ToString();
    }
}