namespace source._2000._2028;

public class Solution
{
    public int[] MissingRolls(int[] rolls, int mean, int n)
    {
        int m = rolls.Length;
        int nSum = (m + n) * mean - rolls.Sum();
        if (nSum < n || nSum > 6 * n) return new int[] { };

        int[] ans = new int[n];

        for (int i = 0; i < n; ++i)
        {
            int max = Math.Min(6, nSum - (n - i - 1));
            ans[i] = max;
            nSum -= max;
        }

        return ans;
    }
}