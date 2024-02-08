namespace source._0200._239;

public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        int n = nums.Length;
        var queue = new PriorityQueue<Tuple<int, int>, int>();
        for (var i = 0; i < k; ++i)
            queue.Enqueue(new Tuple<int, int>(nums[i], i), -nums[i]);

        var res = new List<int>();
        res.Add(queue.Peek().Item1);
        for (int i = k; i < n; ++i)
        {
            while (queue.Count > 0 && queue.Peek().Item2 <= i - k)
                queue.Dequeue();

            queue.Enqueue(new Tuple<int, int>(nums[i], i), -nums[i]);
            res.Add(queue.Peek().Item1);
        }

        return res.ToArray();
    }
}