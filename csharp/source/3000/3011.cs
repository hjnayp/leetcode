namespace source._3000._3011;

public class Solution
{
    public bool CanSortArray(int[] nums)
    {
        IList<int> numArr = new List<int>();
        int max = nums[0];
        int min = nums[0];
        uint bitCnt = GetBitOneCnt(nums[0]);
        for (int i = 1; i < nums.Length; i++)
        {
            if (bitCnt == GetBitOneCnt(nums[i]))
            {
                max = Math.Max(max, nums[i]);
                min = Math.Min(min, nums[i]);
                continue;
            }

            numArr.Add(min);
            numArr.Add(max);
            min = nums[i];
            max = nums[i];
            bitCnt = GetBitOneCnt(nums[i]);
        }
        
        numArr.Add(min);
        numArr.Add(max);

        return IsOrderArray(numArr);

        uint GetBitOneCnt(int num)
        {
            uint cnt = 0;
            for (int i = 0; i <= 8; ++i)
            {
                if ((num & (1 << i)) != 0) ++cnt;
            }

            return cnt;
        }

        bool IsOrderArray(IList<int> arr)
        {
            for (int i = 1; i < arr.Count; ++i)
            {
                if (arr[i] < arr[i - 1]) return false;
            }

            return true;
        }
    }
}