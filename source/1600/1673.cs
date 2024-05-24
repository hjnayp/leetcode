namespace source._1600._1673;

public class Solution
{
    public int[] MostCompetitive(int[] nums, int k)
    {
        var s = new Stack<int>();
        int n = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            while (n - i + s.Count > k && s.Count > 0 && s.Peek() > num)
            {
                s.Pop();
            }

            s.Push(num);
        }

        IEnumerable<int> res = s.Reverse();

        return res.Take(k).ToArray();
    }
}