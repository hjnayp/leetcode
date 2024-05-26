namespace source._0200._215;

public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        int n = nums.Length;
        QuickSelectSort(nums, 0, n - 1, n - k);
        return nums[^k];
    }

    private void QuickSelectSort(int[] nums, int left, int right, int k)
    {
        if (left >= right) return;
        int l = left - 1;
        int r = right + 1;
        int pivot = nums[(left + right) / 2];
        while (l < r)
        {
            do
            {
                ++l;
            } while (nums[l] < pivot);

            do
            {
                --r;
            } while (nums[r] > pivot);

            if (l < r)
            {
                (nums[l], nums[r]) = (nums[r], nums[l]);
            }
        }

        if (k <= r)
        {
            QuickSelectSort(nums, left, r, k);
        }
        else
        {
            QuickSelectSort(nums, r + 1, right, k);
        }
    }
}