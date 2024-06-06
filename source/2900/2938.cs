namespace source._2900._2938;

public class Solution
{
    public long MinimumSteps(string s)
    {
        long res = 0;
        long idx = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != '0') continue;
            res += i - idx;
            ++idx;
        }

        return res;
    }
}