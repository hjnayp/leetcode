namespace source._1200._1287;

public class Solution
{
    public int FindSpecialInteger(int[] arr)
    {
        int m = arr.Length / 4 + 1;
        for (int i = 0; i < arr.Length; i++)
        {
            int index = BinarySearch(arr, i, arr.Length - 1, arr[i]);
            if (index == -1) continue;

            int offset = index - i + 1;
            if (offset >= m) return arr[i];
        }

        return -1;
    }

    private int BinarySearch(int[] arr, int left, int right, int target)
    {
        int index = -1;
        while (left <= right)
        {
            int mid = (right - left) / 2 + left;
            if (arr[mid] == target)
            {
                index = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return index;
    }
}