namespace source._2200._2200;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-all-k-distant-indices-in-an-array">
///         2200. Find All K-Distant Indices in an Array
///     </a>
/// </summary>
public class Solution
{
    public IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        int kCount = 0;
        for (int i = 0; i < k; ++i)
        {
            if (nums[i] != key) continue;
            ++kCount;
        }

        List<int> res = [];
        for (int l = 0, r = k; l < nums.Length; ++r, ++l)
        {
            if (r < nums.Length && nums[r] == key)
                ++kCount;

            if (kCount > 0)
                res.Add(l);

            if (l >= k && nums[l - k] == key)
                --kCount;
        }

        return res;
    }
}