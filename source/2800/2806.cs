namespace source._2800._2806;

public class Solution
{
    private const int kAccountBalance = 100;

    public int AccountBalanceAfterPurchase(int purchaseAmount)
    {
        int a = purchaseAmount / 10;
        int b = purchaseAmount % 10;
        a += b >= 5 ? 1 : 0;
        return kAccountBalance - a * 10;
    }
}