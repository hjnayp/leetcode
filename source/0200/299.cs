namespace source._0200._299;

public class Solution
{
    public string GetHint(string secret, string guess)
    {
        var bulls = 0;
        var cntS = new int [10];
        var cntG = new int [10];
        for (var i = 0; i < secret.Length; i++)
        {
            if (secret[i] == guess[i])
            {
                ++bulls;
            }
            else
            {
                cntS[secret[i] - '0']++;
                cntG[guess[i] - '0']++;
            }
        }

        var cows = 0;
        for (var i = 0; i < 10; ++i)
            cows += Math.Min(cntS[i], cntG[i]);
        return $"{bulls}A{cows}B";
    }
}