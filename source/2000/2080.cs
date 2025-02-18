namespace source._2000._2080;

/// <summary>
///     <a href="https://leetcode.cn/problems/range-frequency-queries">
///         2080. Range Frequency Queries
///     </a>
/// </summary>
public class RangeFreqQuery
{
    private readonly Dictionary<int, IList<int>> _numToPoses = new();

    public RangeFreqQuery(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int num = arr[i];
            _numToPoses.TryAdd(num, []);
            _numToPoses[num].Add(i);
        }
    }

    public int Query(int left, int right, int value)
    {
        if (_numToPoses.TryGetValue(value, out IList<int>? poses) == false) return 0;

        int low = LowerBound(poses, left);
        int up = UpperBound(poses, right);
        return up - low;
    }

    /// <summary>
    ///     First index that the value not lower than target
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    private static int LowerBound(IList<int> arr, int target)
    {
        int low = 0;
        int high = arr.Count - 1;
        while (low <= high)
        {
            int mid = (high - low) / 2 + low;
            if (arr[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return low;
    }

    /// <summary>
    ///     First index that the value exceeds the target
    /// </summary>
    /// <param name="arr">The list of integers in which the upper bound is to be located</param>
    /// <param name="target">The target value for checking the upper bound</param>
    /// <returns>Returns the index of the first element greater than the target value</returns>
    private static int UpperBound(IList<int> arr, int target)
    {
        int low = 0;
        int high = arr.Count - 1;
        while (low <= high)
        {
            int mid = (high - low) / 2 + low;
            if (arr[mid] > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return low;
    }
}