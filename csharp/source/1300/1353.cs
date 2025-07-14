namespace source._1300._1353;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximum-number-of-events-that-can-be-attended">
///         1353. Maximum Number of Events That Can Be Attended
///     </a>
/// </summary>
public class Solution
{
    public int MaxEvents(int[][] events)
    {
        int maxEnd = events[0][1];
        Array.Sort(events, (a, b) =>
        {
            maxEnd = Math.Max(maxEnd, Math.Max(a[1], b[1]));
            return a[0] - b[0];
        });

        PriorityQueue<int, int> pq = new();
        int count = 0;
        for (int i = 1, j = 0, n = events.Length; i <= maxEnd; ++i)
        {
            while (j < n && events[j][0] <= i)
            {
                int endDay = events[j++][1];
                pq.Enqueue(endDay, endDay);
            }

            while (pq.Count > 0 && pq.Peek() < i)
            {
                pq.Dequeue();
            }

            if (pq.Count <= 0) continue;

            pq.Dequeue();
            ++count;
        }

        return count;
    }
}