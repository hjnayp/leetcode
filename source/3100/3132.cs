namespace source._3100._3132;

public class Solution
{
    public int MinimumAddedInteger(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);

        int n = nums1.Length;
        int m = nums2.Length;
        for (int i = 2; i > 0; --i)
        {
            int p1 = i + 1;
            int p2 = 1;
            int difference = nums1[i] - nums2[0];

            while (IsPointersInRange(p1, p2))
            {
                if (IsSameDifference(p1, p2, difference))
                {
                    ++p2;
                }

                ++p1;
            }

            if (p2 == m)
            {
                return nums2[0] - nums1[i];
            }
        }

        return nums2[0] - nums1[0];

        bool IsPointersInRange(int p1, int p2)
        {
            return p1 < n && p2 < m;
        }

        bool IsSameDifference(int i, int j, int difference)
        {
            return nums1[i] - nums2[j] == difference;
        }
    }
}