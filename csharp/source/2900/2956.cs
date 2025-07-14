namespace source._2900._2956;

public class Solution
{
    public int[] FindIntersectionValues(int[] nums1, int[] nums2)
    {
        HashSet<int> nums1Set = [];
        HashSet<int> nums2Set = [];

        foreach (int num in nums1) nums1Set.Add(num);
        foreach (int num in nums2) nums2Set.Add(num);

        int existInNum2 = nums1.Count(num => nums2Set.Contains(num));
        int existInNum1 = nums2.Count(num => nums1Set.Contains(num));

        return [existInNum2, existInNum1];
    }
}