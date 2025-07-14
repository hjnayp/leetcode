namespace source._3200._3258;

/// <summary>
///     <a href="https://leetcode.cn/problems/count-substrings-that-satisfy-k-constraint-i">
///         Count Substrings That Satisfy K-Constraint I
///     </a>
/// </summary>
public class Solution
{
    public int CountKConstraintSubstrings(string s, int k)
    {
        int count = 0;
        int left = 0;
        int right = 0;
        int oneCount = 0;
        int zeroCount = 0;
        int n = s.Length;

        while (right < n)
        {
            char ch = s[right];
            if (ch == '0')
            {
                zeroCount++;
            }
            else
            {
                oneCount++;
            }

            if (zeroCount > k && oneCount > k)
            {
                int len = right - left;
                while (zeroCount > k && oneCount > k)
                {
                    char rmCh = s[left++];
                    if (rmCh == '0')
                    {
                        zeroCount--;
                    }
                    else
                    {
                        oneCount--;
                    }
                }

                int newLen = right - left;
                count += (1 + len) * len / 2 - (1 + newLen) * newLen / 2;
            }

            if (right == n - 1)
            {
                int len = right - left + 1;
                count += (1 + len) * len / 2;
            }

            ++right;
        }

        return count;
    }
}