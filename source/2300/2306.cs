namespace source._2300._2306;

/// <summary>
///     <a href="https://leetcode.cn/problems/naming-a-company">
///         Naming a Company
///     </a>
/// </summary>
public class Solution
{
    public long DistinctNames(string[] ideas)
    {
        IDictionary<char, HashSet<string>> firstCharToStringSet = new Dictionary<char, HashSet<string>>();
        foreach (string idea in ideas)
        {
            char firstChar = idea[0];
            string leftStr = idea.Length > 1 ? idea.Substring(1) : "";
            firstCharToStringSet.TryAdd(firstChar, new HashSet<string>());
            firstCharToStringSet[firstChar].Add(leftStr);
        }

        long count = 0;
        foreach ((char firstChar, HashSet<string>? strs) in firstCharToStringSet)
        {
            foreach ((char firstChar2, HashSet<string>? strs2) in firstCharToStringSet)
            {
                if (firstChar == firstChar2) continue;
                int inter = strs.Intersect(strs2).Count();
                count += (strs.Count - inter) * (strs2.Count - inter);
            }
        }

        return count;
    }
}