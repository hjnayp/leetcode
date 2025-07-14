namespace source._3100._3117;

public class Solution
{
    private const int UpLimit = (1 << 29) - 1;

    public int MinimumValueSum(int[] nums, int[] andValues)
    {
        int m = nums.Length;
        int n = andValues.Length;
        var indexToValueMap = new Dictionary<int, int>[m * n];
        for (int i = 0; i < m * n; ++i)
        {
            indexToValueMap[i] = new Dictionary<int, int>();
        }

        int matchedPairCount = FindMatchCount(0, 0, -1);
        return matchedPairCount < UpLimit ? matchedPairCount : -1;

        int FindMatchCount(int i, int j, int andValue)
        {
            if (i == nums.Length && j == andValues.Length)
            {
                return 0;
            }

            if (i == nums.Length || j == andValues.Length)
            {
                return UpLimit;
            }

            int index = PairToIndex(i, j);
            if (indexToValueMap[index].ContainsKey(andValue))
            {
                return indexToValueMap[index][andValue];
            }

            andValue &= nums[i];
            if (andValue < andValues[j])
            {
                return UpLimit;
            }

            int res = FindMatchCount(i + 1, j, andValue);
            if (andValue == andValues[j])
            {
                res = Math.Min(res, FindMatchCount(i + 1, j + 1, UpLimit) + nums[i]);
            }

            indexToValueMap[index][andValue] = res;
            return res;
        }

        int PairToIndex(int i, int j)
        {
            return i * n + j;
        }
    }
}