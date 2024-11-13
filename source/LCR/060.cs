namespace source.LCR._060;

/// <summary>
///     <a href="https://leetcode.cn/problems/g5c51o">
///         前K个高频元素
///     </a>
/// </summary>
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> numToFrequent = new();
        foreach (int num in nums)
        {
            numToFrequent.TryAdd(num, 0);
            numToFrequent[num]++;
        }

        PriorityQueue<int, int> stack = new();
        foreach ((int key, int value) in numToFrequent)
        {
            if (stack.Count < k)
            {
                stack.Enqueue(key, value);
            }
            else if (stack.Peek() < value)
            {
                stack.Dequeue();
                stack.Enqueue(key, value);
            }
        }

        List<int> res = [];
        while (stack.Count > 0)
        {
            res.Add(stack.Dequeue());
        }

        return res.ToArray();
    }
}