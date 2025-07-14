namespace source._3100._3159;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-occurrences-of-an-element-in-an-array">
///         3159. Find Occurrences of an Element in an Array
///     </a>
/// </summary>
public class Solution
{
    public int[] OccurrencesOfElement(int[] nums, int[] queries, int x)
    {
        List<int> countIndexes = [];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == x)
            {
                countIndexes.Add(i);
            }
        }

        int[] result = new int[queries.Length];
        for (var i = 0; i < queries.Length; i++)
        {
            int count = queries[i];
            if (count > countIndexes.Count)
            {
                result[i] = -1;
            }
            else
            {
                result[i] = countIndexes[count - 1];
            }
        }

        return result;
    }
}