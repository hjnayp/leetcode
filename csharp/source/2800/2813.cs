namespace source._2800._2813;

public class Solution
{
    public long FindMaximumElegance(int[][] items, int k)
    {
        Array.Sort(items, (a, b) => b[0] - a[0]);
        ISet<int> categories = new HashSet<int>();
        Stack<int> profitStack = new();
        long profitSum = 0;
        long maxElegance = 0;
        for (int i = 0; i < items.Length; ++i)
        {
            int[] item = items[i];
            int iProfit = item[0];
            int iCategory = item[1];
            if (i < k)
            {
                profitSum += iProfit;
                if (!categories.Add(iCategory)) profitStack.Push(iProfit);
            }
            else if (profitStack.Any() && categories.Add(iCategory))
            {
                profitSum += iProfit - profitStack.Pop();
            }

            maxElegance = Math.Max(maxElegance, profitSum + (long)categories.Count * categories.Count);
        }

        return maxElegance;
    }
}