namespace source._2000._2024;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximize-the-confusion-of-an-exam">Link</a>
/// </summary>
public class Solution
{
    public int MaxConsecutiveAnswers(string answerKey, int k)
    {
        return Math.Max(MaxConsecutiveCharCount(answerKey, k, 'T'), MaxConsecutiveCharCount(answerKey, k, 'F'));
    }

    private int MaxConsecutiveCharCount(string answerKey, int k, char target)
    {
        int n = answerKey.Length;
        int left = 0;
        int right = 0;
        int targetCharCount = 0;
        int maxConsecutiveCharCount = 0;
        while (right < n)
        {
            char answer = answerKey[right];
            if (answer == target)
            {
                ++targetCharCount;
            }

            while (targetCharCount > k)
            {
                if (answerKey[left] == target)
                {
                    --targetCharCount;
                }

                ++left;
            }

            maxConsecutiveCharCount = Math.Max(maxConsecutiveCharCount, right - left + 1);
            ++right;
        }

        return maxConsecutiveCharCount;
    }
}