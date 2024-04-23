using System.Text;

namespace source._0000._06;

/// <summary>
///     https://leetcode.cn/problems/zigzag-conversion
/// </summary>
public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1) return s;
        var rows = new StringBuilder[numRows];
        for (var i = 0; i < numRows; i++)
            rows[i] = new StringBuilder();

        var idx = 0;
        var direction = 1;
        foreach (char c in s)
        {
            rows[idx].Append(c);
            idx += direction;
            if (idx == 0 || idx == numRows - 1)
                direction = -direction;
        }

        var res = new StringBuilder();
        foreach (StringBuilder row in rows)
            res.Append(row);
        return res.ToString();
    }
}