namespace source._2800._2848;

public class Solution
{
    public int NumberOfPoints(IList<IList<int>> nums)
    {
        int maxPoint = nums.Select(num => num[1]).Max();
        int[] diff = new int[maxPoint + 2];
        foreach (IList<int> range in nums)
        {
            int l = range[0];
            int r = range[1];

            diff[l]++;
            diff[r + 1]--;
        }

        int count = 0;
        int res = 0;
        foreach (int i in diff)
        {
            count += i;
            if (count > 0)
            {
                ++res;
            }
        }

        return res;
    }
}