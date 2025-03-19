namespace source._2600._2610;

/// <summary>
///     <a href="https://leetcode.cn/problems/convert-an-array-into-a-2d-array-with-conditions">
///         2610. Convert an Array Into a 2D Array With Conditions
///     </a>
/// </summary>
public class Solution
{
    public IList<IList<int>> FindMatrix(int[] nums)
    {
        var numToCount = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            numToCount.TryAdd(num, 0);
            numToCount[num]++;
        }

        IList<IList<int>> res = new List<IList<int>>();
        while (numToCount.Count > 0)
        {
            List<int> row = numToCount.Keys.ToList();
            res.Add(row);

            foreach (int num in row)
            {
                --numToCount[num];
                if (numToCount[num] == 0)
                {
                    numToCount.Remove(num);
                }
            }
        }

        return res;
    }
}