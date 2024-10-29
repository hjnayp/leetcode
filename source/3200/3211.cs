using System.Text;

namespace source._3200._3200._3211;

public class Solution
{
    public IList<string> ValidStrings(int n)
    {
        var sb = new StringBuilder();
        var strs = new List<string>();

        Dfs(-1);
        return strs;

        void Dfs(int prevDigit)
        {
            if (sb.Length >= n)
            {
                strs.Add(sb.ToString());
                return;
            }

            if (prevDigit != 0)
            {
                sb.Append('0');
                Dfs(0);
                sb.Remove(sb.Length - 1, 1);
            }

            sb.Append('1');
            Dfs(1);
            sb.Remove(sb.Length - 1, 1);
        }
    }
}