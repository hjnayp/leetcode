namespace source._0100._162;

public class Solution
{
    public int FindPeakElement(int[] nums)
    {
        int n = nums.Length;
        int left = 0;
        int right = n - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (Less(mid + 1, mid) && Less(mid - 1, mid))
                return mid;

            if (Less(mid, mid + 1))
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;

        bool Less(int a, int b)
        {
            Tuple<int, int> num_a = Get(a);
            Tuple<int, int> num_b = Get(b);

            if (num_a.Item1 != num_b.Item1)
                return num_a.Item1 < num_b.Item1;
            return num_a.Item2 < num_b.Item2;
        }

        Tuple<int, int> Get(int i)
        {
            if (i == -1 || i == n)
                return new Tuple<int, int>(0, 0);

            return new Tuple<int, int>(1, nums[i]);
        }
    }
}