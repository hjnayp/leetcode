namespace source._0700._732;

/// <summary>
///     <a href="https://leetcode.cn/problems/my-calendar-iii">
///         732. My Calendar III
///     </a>
/// </summary>
public class MyCalendarThree
{
    private const int MAX_SIZE = 1_000_000_000;

    private readonly IDictionary<int, int[]> tree_ = new Dictionary<int, int[]>();

    public int Book(int start, int end)
    {
        Update(start, end - 1, 0, MAX_SIZE, 1);
        return tree_[1][0];
    }

    private void Update(int start, int end, int left, int right, int index)
    {
        if (right < start || end < left) return;

        if (left >= start && end >= right)
        {
            if (tree_.ContainsKey(index) == false)
            {
                tree_.Add(index, [0, 0]);
            }

            tree_[index][0]++;
            tree_[index][1]++;
            return;
        }

        int mid = (left + right) >> 1;
        Update(start, end, left, mid, 2 * index);
        Update(start, end, mid + 1, right, 2 * index + 1);

        if (tree_.ContainsKey(index) == false)
        {
            tree_.Add(index, [0, 0]);
        }

        if (tree_.ContainsKey(index * 2) == false)
        {
            tree_.Add(index * 2, [0, 0]);
        }

        if (tree_.ContainsKey(2 * index + 1) == false)
        {
            tree_.Add(2 * index + 1, [0, 0]);
        }

        tree_[index][0] = tree_[index][1] + Math.Max(tree_[2 * index][0], tree_[2 * index + 1][0]);
    }
}