namespace source._3100._3131;

public class Solution
{
    public int AddedInteger(int[] nums1, int[] nums2)
    {
        return nums2.Min() - nums1.Min();
    }
}