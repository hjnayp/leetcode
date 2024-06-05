namespace source._3000._3072;

public class Solution
{
    private class BinaryIndexedTree
    {
        private int[] _tree;

        public BinaryIndexedTree(int n)
        {
            _tree = new int[n + 1];
        }

        public void Add(int i)
        {
            while (i < _tree.Length)
            {
                ++_tree[i];
                i += LowBit(i);
            }
        }

        public int Get(int i)
        {
            int sum = 0;
            while (i > 0)
            {
                sum += _tree[i];
                i -= LowBit(i);
            }

            return sum;
        }

        private int LowBit(int i)
        {
            return i & -i;
        }
    }

    public int[] ResultArray(int[] nums)
    {
        int n = nums.Length;
        int[] sortedNums = nums.Take(n).ToArray();
        Array.Sort(sortedNums);
        IDictionary<int, int> val2Idx = new Dictionary<int, int>();
        for (int i = 0; i < n; i++) val2Idx.TryAdd(sortedNums[i], i + 1);

        IList<int> arr1 = new List<int> { nums[0] };
        IList<int> arr2 = new List<int> { nums[1] };
        BinaryIndexedTree tree1 = new(n);
        BinaryIndexedTree tree2 = new(n);
        tree1.Add(val2Idx[nums[0]]);
        tree2.Add(val2Idx[nums[1]]);

        for (int i = 2; i < n; ++i)
        {
            int cnt1 = arr1.Count - tree1.Get(val2Idx[nums[i]]);
            int cnt2 = arr2.Count - tree2.Get(val2Idx[nums[i]]);

            if (cnt1 > cnt2 || (cnt1 == cnt2 && arr1.Count <= arr2.Count))
            {
                arr1.Add(nums[i]);
                tree1.Add(val2Idx[nums[i]]);
            }
            else
            {
                arr2.Add(nums[i]);
                tree2.Add(val2Idx[nums[i]]);
            }
        }

        int idx = 0;
        foreach (int i in arr1) nums[idx++] = i;
        foreach (int i in arr2) nums[idx++] = i;
        return nums;
    }
}