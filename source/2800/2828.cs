namespace source._2800._2828;

public class Solution
{
    public bool IsAcronym(IList<string> words, string s)
    {
        if (s.Length != words.Count)
            return false;

        return !words.Where((t, i) => s[i] != t[0]).Any();
    }
}