namespace source._2300._2376;

/// <summary>
///     <a href="https://leetcode.cn/problems/count-special-integers">
///         Count Special Integers
///     </a>
/// </summary>
public class Solution
{
    private readonly Dictionary<long, int> _keyToCount = new();

    public int CountSpecialNumbers(int num)
    {
        string nStr = num.ToString();
        int specialNumberCount = 0;
        int prod = 9;
        for (int i = 0; i < nStr.Length - 1; i++)
        {
            specialNumberCount += prod;
            prod *= 9 - i;
        }

        specialNumberCount += CountSpecialNumbersRecursive(0, false, nStr);
        return specialNumberCount;
    }

    private static int CountNumberOnes(int num)
    {
        int count = 0;
        while (num > 0)
        {
            ++count;
            num &= num - 1;
        }

        return count;
    }

    private int CountSpecialNumbersRecursive(int usedNumberBitMask, bool isPrefixSmaller, string str)
    {
        int maskOnes = CountNumberOnes(usedNumberBitMask);
        if (maskOnes == str.Length) return 1;

        long key = (usedNumberBitMask << 1) + (isPrefixSmaller ? 1 : 0);
        if (_keyToCount.TryGetValue(key, out int count)) return count;

        int res = 0;
        int lower = usedNumberBitMask == 0 ? 1 : 0;
        int upper = isPrefixSmaller ? 9 : str[maskOnes] - '0';
        for (int i = lower; i <= upper; i++)
        {
            if (((usedNumberBitMask >> i) & 1) == 0)
            {
                res += CountSpecialNumbersRecursive(usedNumberBitMask | (1 << i), isPrefixSmaller || i < upper, str);
            }
        }

        _keyToCount[key] = res;
        return res;
    }
}