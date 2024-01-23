using System.Text;

namespace source._2700._2788;

public class Solution
{
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator)
    {
        var res = new List<string>();
        foreach (var word in words)
        {
            var sb = new StringBuilder();
            foreach (var c in word)
            {
                if (c == separator)
                {
                    if (sb.Length <= 0)
                        continue;

                    res.Add(sb.ToString());
                    sb.Clear();
                }
                else
                {
                    sb.Append(c);
                }
            }

            if (sb.Length > 0)
                res.Add(sb.ToString());
        }

        return res;
    }
}