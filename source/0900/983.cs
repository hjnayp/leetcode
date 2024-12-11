namespace source._0900._983;

/// <summary>
///     <a href="https://leetcode.cn/problems/minimum-cost-for-tickets">
///         983. Minimum Cost For Tickets
///     </a>
/// </summary>
public class Solution
{
    public int MincostTickets(int[] days, int[] costs)
    {
        int n = days.Length;
        int[] duration = [1, 7, 30];
        int[] memory = new int [n];
        Array.Fill(memory, -1);

        return Dp(0);

        int Dp(int dayIndex)
        {
            if (dayIndex >= n) return 0;

            if (memory[dayIndex] is not -1) return memory[dayIndex];

            int res = int.MaxValue;
            int newDay = dayIndex;
            for (int i = 0; i < 3; ++i)
            {
                while (newDay < days.Length && days[newDay] < days[dayIndex] + duration[i])
                {
                    ++newDay;
                }

                res = Math.Min(res, Dp(newDay) + costs[i]);
            }

            return memory[dayIndex] = res;
        }
    }
}