namespace source._2200._2289;

public class Solution
{
    public int TotalSteps(int[] nums)
    {
        var st = new Stack<(int, int)>();
        int ans = 0;
        foreach (int num in nums)
        {
            int maxT = 0;
            while (st.Any() && st.Peek().Item1 <= num)
            {
                maxT = Math.Max(maxT, st.Peek().Item2);
                st.Pop();
            }

            maxT = st.Any() ? maxT + 1 : 0;
            ans = Math.Max(ans, maxT);
            st.Push((num, maxT));
        }

        return ans;
    }
}