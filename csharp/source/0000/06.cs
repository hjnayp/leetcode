using System.Text;

namespace source._0000._06;

/// <summary>
///     <a href="https://leetcode.cn/problems/zigzag-conversion">ZigZag Conversion</a>
/// </summary>
public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1) return s;
        var rows = new StringBuilder[numRows];
        for (int i = 0; i < numRows; i++)
        {
            rows[i] = new StringBuilder();
        }

        int idx = 0;
        int direction = 1;

        foreach (char c in s)
        {
            rows[idx].Append(c);
            idx += direction;

            if (idx == 0 || idx == numRows - 1)
            {
                direction = -direction;
            }
        }

        StringBuilder res = new();
        foreach (StringBuilder row in rows)
        {
            res.Append(row);
        }

        return res.ToString();
    }
}