namespace source._1700._1793;

public class Solution
{
    public int MaximumScore(int[] nums, int k)
    {
        int left = k - 1;
        int right = k + 1;

        int numsLen = nums.Length;
        int maxScore = nums[k];

        int minNum = nums[k];
        while (true)
        {
            while (left >= 0 && nums[left] >= minNum) left--;
            while (right < numsLen && nums[right] >= minNum) right++;

            maxScore = Math.Max(maxScore, minNum * (right - left - 1));
            if (left < 0 && right >= numsLen) break;

            minNum = Math.Max(left >= 0 ? nums[left] : 0, right < numsLen ? nums[right] : 0);
        }

        return maxScore;
    }
}