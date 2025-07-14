namespace source._0300._315;

/// <summary>
///     <a href="https://leetcode.cn/problems/count-of-smaller-numbers-after-self/description/">
///         315. Count of Smaller Numbers After Self
///     </a>
/// </summary>
public class Solution
{
    public IList<int> CountSmaller(int[] nums)
    {
        var tree = new Tree(nums);
        var counts = new List<int>();

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            int num = nums[i];
            int id = tree.GetId(num);
            counts.Add(tree.Query(id - 1));
            tree.Update(id);
        }

        counts.Reverse();
        return counts;
    }
}

internal class Tree
{
    private readonly int[] _array;
    private readonly int[] _count;

    public Tree(int[] nums)
    {
        var hashset = new HashSet<int>((int[])nums.Clone());
        _array = hashset.ToArray();
        Array.Sort(_array);

        _count = new int[nums.Length];
        Array.Fill(_count, 0);
    }

    public void Update(int pos)
    {
        while (pos < _count.Length)
        {
            _count[pos] += 1;
            pos += LowBit(pos);
        }
    }

    public int Query(int pos)
    {
        int count = 0;
        while (pos > 0)
        {
            count += _count[pos];
            pos -= LowBit(pos);
        }

        return count;
    }

    public int GetId(int num)
    {
        return Array.BinarySearch(_array, num) + 1;
    }

    private static int LowBit(int num)
    {
        return num & -num;
    }
}