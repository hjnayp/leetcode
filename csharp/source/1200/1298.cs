namespace source._1200._1298;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximum-candies-you-can-get-from-boxes">
///         1298. Maximum Candies You Can Get from Boxes
///     </a>
/// </summary>
public class Solution
{
    public int MaxCandies(int[] status,
                          int[] candies,
                          int[][] keys,
                          int[][] containedBoxes,
                          int[] initialBoxes
    )
    {
        Queue<int> boxes = new(initialBoxes.Where(box => status[box] == 1));
        List<int> waitOpenedBoxes = initialBoxes.Where(box => status[box] == 0).ToList();
        int count = 0;

        while (boxes.Count > 0)
        {
            int box = boxes.Dequeue();
            count += candies[box];

            foreach (int i in keys[box])
            {
                status[i] = 1;
            }

            int[] newBoxes = containedBoxes[box];
            waitOpenedBoxes.AddRange(newBoxes);
            waitOpenedBoxes.ForEach(value =>
            {
                if (status[value] == 1)
                {
                    boxes.Enqueue(value);
                }
            });

            waitOpenedBoxes = waitOpenedBoxes.Where(value => status[value] == 0).ToList();
        }

        return count;
    }
}