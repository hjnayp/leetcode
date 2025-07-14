namespace source._1700._1738;

public class Solution
{
    public int KthLargestValue(int[][] matrix, int k)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int[,] dp = new int[m, n];
        dp[0, 0] = matrix[0][0];
        for (int i = 1; i < m; ++i)
        {
            dp[i, 0] = dp[i - 1, 0] ^ matrix[i][0];
        }

        for (int j = 1; j < n; ++j)
        {
            dp[0, j] = dp[0, j - 1] ^ matrix[0][j];
        }

        for (int i = 1; i < m; ++i)
        {
            for (int j = 1; j < n; ++j)
            {
                dp[i, j] = dp[i - 1, j] ^ dp[i, j - 1] ^ dp[i - 1, j - 1] ^ matrix[i][j];
            }
        }

        int nums = m * n;
        return QuickSelect(dp.Cast<int>().ToList(), 0, nums - 1, nums - k);
    }

    private int QuickSelect(IList<int> nums, int left, int right, int k)
    {
        if (left >= right) return nums[k];
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

        return k <= r
            ? QuickSelect(nums, left, r, k)
            : QuickSelect(nums, r + 1, right, k);
    }
}