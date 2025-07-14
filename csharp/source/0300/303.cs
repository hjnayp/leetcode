namespace source._0300;

public class NumArray
{

    private List<int> _preSum;

    public NumArray(int[] nums)
    {
        int n = nums.Length;
        _preSum = new List<int>(n + 1);
        _preSum.Add(0);
        for (var i = 0; i < n; i++)
            _preSum.Add(_preSum[i] + nums[i]);
    }

    public int SumRange(int left, int right)
    {
        return _preSum[right + 1] - _preSum[left];
    }
}