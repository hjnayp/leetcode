namespace source._3100._3152;

public class Solution
{
    public bool[] IsArraySpecial(int[] nums, int[][] queries)
    {
        int m = nums.Length;
        int[] notSameParitySubArrayLength = new int[m];
        Array.Fill(notSameParitySubArrayLength, 1);
        for (int i = 1; i < m; ++i)
        {
            if (!IsSameParity(nums[i], nums[i - 1]))
            {
                notSameParitySubArrayLength[i] = notSameParitySubArrayLength[i - 1] + 1;
            }
        }

        return queries.Select(IsSubArraySpecial).ToArray();

        bool IsSubArraySpecial(int[] query)
        {
            int left = query[0];
            int right = query[1];
            int subArrayLenght = right - left + 1;
            return notSameParitySubArrayLength[right] >= subArrayLenght;
        }

        bool IsSameParity(int a, int b)
        {
            return ((a ^ b) & 1) == 0;
        }
    }
}