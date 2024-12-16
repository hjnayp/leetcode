namespace source._1800._1847;

/// <summary>
///     <a href="https://leetcode.cn/problems/closest-room">
///         1847. Closest Room
///     </a>
/// </summary>
public class Solution
{
    public int[] ClosestRoom(int[][] rooms, int[][] queries)
    {
        int m = rooms.Length;
        int n = queries.Length;

        var events = new List<Event>();

        for (int i = 0; i < m; i++)
        {
            events.Add(new Event(0, rooms[i][1], rooms[i][0], i));
        }

        for (int i = 0; i < n; i++)
        {
            events.Add(new Event(1, queries[i][1], queries[i][0], i));
        }

        events.Sort();
        int[] result = new int[n];
        Array.Fill(result, -1);
        SortedSet<int> roomIds = [];
        foreach (Event e in events)
        {
            if (e.Type == 0)
            {
                roomIds.Add(e.Id);
            }
            else
            {
                int distance = int.MaxValue;
                int celling = roomIds.GetViewBetween(e.Id, int.MaxValue).Min;
                if (celling is not 0 && celling - e.Id < distance)
                {
                    distance = celling - e.Id;
                    result[e.Origin] = celling;
                }

                int floor = roomIds.GetViewBetween(0, e.Id).Max;
                if (floor is not 0 && e.Id - floor <= distance)
                {
                    result[e.Origin] = floor;
                }
            }
        }

        return result;
    }

    private class Event(int type, int size, int id, int origin)
        : IComparable<Event>
    {
        public int Type { get; } = type;

        public int Size { get; } = size;

        public int Id { get; } = id;

        public int Origin { get; } = origin;

        public int CompareTo(Event? other)
        {
            if (other is null) return -1;
            return Size == other.Size
                ? Type.CompareTo(other.Type)
                : other.Size.CompareTo(Size);
        }
    }
}