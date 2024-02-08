namespace source._0200._292;

public class Solution
{
    public bool CanWinNim(int n)
    {
        return n <= 3 || n % 4 != 0;
    }
}