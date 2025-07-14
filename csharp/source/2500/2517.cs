namespace source._2500._2517;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximum-tastiness-of-candy-basket/description/">
///         2517. Maximum Tastiness of Candy Basket
///     </a>
/// </summary>
public class Solution
{
    public int MaximumTastiness(int[] price, int k)
    {
        Array.Sort(price);
        int high = (price[^1] - price[0]) / (k - 1);
        int low = 0;
        int maxTastiness = 0;

        while (low <= high)
        {
            int mid = (high - low) / 2 + low;
            if (IsTastiness(mid))
            {
                maxTastiness = mid;
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return maxTastiness;

        bool IsTastiness(int tastiness)
        {
            int count = 1;
            int prev = price[0];
            foreach (int p in price.Skip(1))
            {
                int tastinessDiff = p - prev;
                if (tastinessDiff < tastiness) continue;

                ++count;
                prev = p;
            }

            return count >= k;
        }
    }
}