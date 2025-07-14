namespace source._0500._503;

public class Solution
{
    public int[] NextGreaterElements(int[] nums)
    {
        Stack<int> idxStack = new();
        int n = nums.Length;
        if (n == 0) return Array.Empty<int>();

        int[] res = new int[n];
        for (int i = 0; i < n; i++) res[i] = -1;

        int idx = 1 % n;
        idxStack.Push(0);
        while (idx < 2 * n)
        {
            while (idxStack.Any() && nums[idxStack.Peek()] < nums[idx % n])
            {
                res[idxStack.Pop()] = nums[idx % n];
            }

            if (idxStack.Any() && idx % n == idxStack.Peek()) break;

            idxStack.Push(idx % n);
            ++idx;
        }

        return res;
    }
}