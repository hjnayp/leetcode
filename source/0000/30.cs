namespace source._0000._30;

/// <summary>
///     <a href="https://leetcode.cn/problems/substring-with-concatenation-of-all-words">
///         Substring with Concatenation of All Words
///     </a>
/// </summary>
public class Solution
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        int wordCount = words.Length;
        int wordLen = words[0].Length;
        int strLen = s.Length;
        int subStrLen = wordCount * wordLen;
        IList<int> subStrIndexs = new List<int>();

        for (int start = 0; start < wordLen; ++start)
        {
            if (start + subStrLen > strLen) break;

            IDictionary<string, int> strToCount = new Dictionary<string, int>();
            for (int i = 0; i < wordCount; ++i)
            {
                string word = s.Substring(start + i * wordLen, wordLen);
                strToCount.TryAdd(word, 0);
                ++strToCount[word];
            }

            foreach (string word in words)
            {
                strToCount.TryAdd(word, 0);
                --strToCount[word];
                if (strToCount[word] == 0)
                {
                    strToCount.Remove(word);
                }
            }

            if (strToCount.Count == 0)
            {
                subStrIndexs.Add(start);
            }

            for (int left = start + wordLen; left < strLen - subStrLen + 1; left += wordLen)
            {
                string removeWord = s.Substring(left - wordLen, wordLen);
                strToCount.TryAdd(removeWord, 0);
                --strToCount[removeWord];
                if (strToCount[removeWord] == 0)
                {
                    strToCount.Remove(removeWord);
                }

                string addWord = s.Substring(left + subStrLen - wordLen, wordLen);
                strToCount.TryAdd(addWord, 0);
                ++strToCount[addWord];
                if (strToCount[addWord] == 0)
                {
                    strToCount.Remove(addWord);
                }

                if (strToCount.Count == 0)
                {
                    subStrIndexs.Add(left);
                }
            }
        }

        return subStrIndexs;
    }
}