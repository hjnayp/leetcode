namespace source._3100._3165;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximum-sum-of-subsequence-with-non-adjacent-elements">
///         Maximum Sum of Subsequence With Non-adjacent Elements
///     </a>
/// </summary>
public class Solution
{
    private const int Mod = 1000000007;

    public int MaximumSumSubsequence(int[] nums, int[][] queries)
    {
        int n = nums.Length;
        var tree = new SegTree((uint)n);
        tree.Init(nums);
        long res = 0;
        foreach (int[] query in queries)
        {
            tree.Update(query[0], query[1]);
            res = (res + tree.Query) % Mod;
        }

        return (int)res;
    }

    private class SegNode
    {
        public long NonSelect { get; set; }
        public long LeftSelect { get; set; }
        public long RightSelect { get; set; }
        public long BothSelect { get; set; }
        public long Best => BothSelect;

        public void SetLeaf(long value)
        {
            LeftSelect = RightSelect = NonSelect = 0;
            BothSelect = Math.Max(0, value);
        }
    }

    private class SegTree
    {
        private int _n;
        private SegNode[] _nodes;

        public SegTree(uint size)
        {
            _n = Math.Max(0, (int)size);
            _nodes = new SegNode[_n * 4 + 1];

            for (int i = 0; i < _nodes.Length; i++)
            {
                _nodes[i] = new SegNode();
            }
        }

        public long Query => _nodes[1].Best;

        public void Update(int pos, int value)
        {
            DfsUpdate(1, 1, _n);
            return;

            void DfsUpdate(int x, int left, int right)
            {
                if (left > pos + 1 || right < pos + 1) return;

                if (IsLeaf(left, right))
                {
                    _nodes[x].SetLeaf(value);
                    return;
                }

                int mid = Middle(left, right);
                DfsUpdate(x * 2, left, mid);
                DfsUpdate(x * 2 + 1, mid + 1, right);
                Pushup(x);
            }
        }

        public void Init(int[] nums)
        {
            DfsInit(1, 1, _n);
            return;

            void DfsInit(int x, int left, int right)
            {
                if (IsLeaf(left, right))
                {
                    _nodes[x].SetLeaf(nums[left - 1]);
                    return;
                }

                int mid = Middle(left, right);
                DfsInit(x * 2, left, mid);
                DfsInit(x * 2 + 1, mid + 1, right);
                Pushup(x);
            }
        }

        private void Pushup(int x)
        {
            int left = x * 2;
            int right = x * 2 + 1;

            _nodes[x].NonSelect = Math.Max(
                _nodes[left].NonSelect + _nodes[right].LeftSelect,
                _nodes[left].RightSelect + _nodes[right].NonSelect
            );
            _nodes[x].LeftSelect = Math.Max(
                _nodes[left].LeftSelect + _nodes[right].LeftSelect,
                _nodes[left].BothSelect + _nodes[right].NonSelect
            );
            _nodes[x].RightSelect = Math.Max(
                _nodes[left].NonSelect + _nodes[right].BothSelect,
                _nodes[left].RightSelect + _nodes[right].RightSelect
            );
            _nodes[x].BothSelect = Math.Max(
                _nodes[left].LeftSelect + _nodes[right].BothSelect,
                _nodes[left].BothSelect + _nodes[right].RightSelect
            );
        }

        private static bool IsLeaf(int left, int right)
        {
            return left == right;
        }

        private static int Middle(int left, int right)
        {
            return (right - left) / 2 + left;
        }
    }
}