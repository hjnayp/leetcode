namespace source._1700._1793;

public class Solution
{
    public int MaximumScore(int[] nums, int k)
    {
        int left = k - 1;
        int right = k + 1;
        int m = nums.Length;
        int res = nums[k];
        for (int i = nums[k];;)
        {
            while (left >= 0 && nums[left] >= i) left--;
            while (right < m && nums[right] >= i) right++;
            res = Math.Max(res, i * (right - left - 1));

            if (left < 0 && right >= m) break; 
            i = Math.Max(left >= 0 ? nums[left] : -1, right < m ? nums[right] : -1);
            if (i == -1) break;
        }

        return res;
    }
}