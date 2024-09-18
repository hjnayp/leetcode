namespace source._2300._2332;

/// <summary>
///     <a
///         href="https://leetcode.cn/problems/the-latest-time-to-catch-a-bus">
///         The Latest Time to Catch a Bus
///     </a>
/// </summary>
public class Solution
{
    public int LatestTimeCatchTheBus(int[] buses, int[] passengers, int capacity)
    {
        Array.Sort(passengers);
        Array.Sort(buses);
        int pos = 0;
        int space = 0;

        foreach (int arrive in buses)
        {
            space = capacity;
            while (space > 0 && pos < passengers.Length && passengers[pos] <= arrive)
            {
                space--;
                pos++;
            }
        }

        pos--;
        int lastCatchTime = space > 0 ? buses[buses.Length - 1] : passengers[pos];
        while (pos >= 0 && passengers[pos] == lastCatchTime)
        {
            pos--;
            lastCatchTime--;
        }

        return lastCatchTime;
    }
}