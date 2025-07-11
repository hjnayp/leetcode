namespace source._3100._3169;

public class Solution
{
    public int CountDays(int days, int[][] meetings)
    {
        Array.Sort(meetings, (a, b) => a[0].CompareTo(b[0]));

        int end = 0;
        foreach (var meeting in meetings)
        {
            int l = meeting[0],
                r = meeting[1];

            if (end > r) continue;

            int cost = Math.Min(r - l + 1, r - end);
            days -= cost;
            end = Math.Max(end, r);
        }

        return days;
    }
}