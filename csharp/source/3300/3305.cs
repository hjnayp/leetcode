namespace source._3300._3305;

/// <summary>
///     <a
///         href="https://leetcode.cn/problems/count-of-substrings-containing-every-vowel-and-k-consonants-i">
///         3305. Count of Substrings Containing Every Vowel and K Consonants I
///     </a>
/// </summary>
public class Solution
{
    public int CountOfSubstrings(string word, int k)
    {
        return getValidSubstringCount(k) - getValidSubstringCount(k + 1);

        int getValidSubstringCount(int consonantCount)
        {
            var vowelToCount = new Dictionary<char, int>();
            int res = 0;
            int cCount = 0;
            int len = word.Length;
            int left = 0;
            int right = 0;

            while (left < word.Length)
            {
                while (right < len && (cCount < consonantCount || vowelToCount.Count < 5))
                {
                    char ch = word[right];
                    if (isVowel(ch))
                    {
                        vowelToCount.TryAdd(ch, 0);
                        ++vowelToCount[ch];
                    }
                    else
                    {
                        ++cCount;
                    }

                    ++right;
                }

                if (cCount >= consonantCount && vowelToCount.Count is 5)
                {
                    res += len - right + 1;
                }

                char leftCh = word[left];
                if (isVowel(leftCh))
                {
                    vowelToCount[leftCh]--;
                    if (vowelToCount[leftCh] == 0)
                    {
                        vowelToCount.Remove(leftCh);
                    }
                }
                else
                {
                    --cCount;
                }

                ++left;
            }

            return res;
        }

        bool isVowel(char c)
        {
            return c is 'a' or 'e' or 'i' or 'o' or 'u';
        }
    }
}