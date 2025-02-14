namespace source._1700._1760;

public class Solution
{
    public int MinimumSize(int[] nums, int maxOperations)
    {
        int operationCount = 0;
        int low = 1;
        int high = nums.Max();

        while (low <= high)
        {
            int mid = (high - low) / 2 + low;
            int count = OperationCount(mid);
            if (count > maxOperations)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
                operationCount = mid;
            }
        }

        return operationCount;

        int OperationCount(int maxNum)
        {
            return nums.Sum(num => (num - 1) / maxNum);
        }
    }
}