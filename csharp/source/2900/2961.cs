namespace source._2900._2961;

public class Solution
{
    public IList<int> GetGoodIndices(int[][] variables, int target)
    {
        IList<int> goodIndices = new List<int>();
        for (int i = 0; i < variables.Length; i++)
        {
            int[] variable = variables[i];
            if (PowMod(PowMod(variable[0], variable[1], 10), variable[2], variable[3]) == target)
            {
                goodIndices.Add(i);
            }
        }

        return goodIndices;
    }

    private int PowMod(int x, int y, int mod)
    {
        int res = 1;
        while (y != 0)
        {
            if ((y & 1) != 0)
            {
                res = res * x % mod;
            }

            x = x * x % mod;
            y >>= 1;
        }

        return res;
    }
}