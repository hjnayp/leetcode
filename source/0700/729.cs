namespace source._0700._729;

/// <summary>
///     <a href="https://leetcode.cn/problems/my-calendar-i">
///         729. My Calendar I
///     </a>
/// </summary>
public class MyCalendar
{
    private const int MAX_SIZE = 1_000_000_000;

    private readonly ISet<int> tree_ = new HashSet<int>();
    private readonly ISet<int> lazy_ = new HashSet<int>();

    public bool Book(int start, int end)
    {
        if (IsBooked(start, end - 1, 0, MAX_SIZE, 1))
        {
            return false;
        }

        Update(start, end - 1, 0, MAX_SIZE, 1);
        return true;
    }

    private bool IsBooked(int bookStart, int bookEnd, int left, int right, int index)
    {
        if (bookStart > right || bookEnd < left)
        {
            return false;
        }

        if (lazy_.Contains(index))
        {
            return true;
        }

        if (bookStart <= left && right <= bookEnd)
        {
            return tree_.Contains(index);
        }

        int mid = (left + right) >> 1;
        if (bookEnd <= mid)
        {
            return IsBooked(bookStart, bookEnd, left, mid, 2 * index);
        }

        if (bookStart > mid)
        {
            return IsBooked(bookStart, bookEnd, mid + 1, right, 2 * index + 1);
        }

        return IsBooked(bookStart, bookEnd, left, mid, 2 * index)
            || IsBooked(bookStart, bookEnd, mid + 1, right, 2 * index + 1);
    }

    private void Update(int start, int end, int left, int right, int index)
    {
        if (right < start || end < left)
        {
            return;
        }

        if (start <= left && right <= end)
        {
            tree_.Add(index);
            lazy_.Add(index);
        }
        else
        {
            int mid = (left + right) >> 1;
            Update(start, end, left, mid, 2 * index);
            Update(start, end, mid + 1, right, 2 * index + 1);
            tree_.Add(index);
        }
    }
}