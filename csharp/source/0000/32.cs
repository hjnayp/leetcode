namespace source._0000._32;

/// <summary>
///     <a href="https://leetcode.cn/problems/longest-valid-parentheses">
///         Longest Valid Parentheses
///     </a>
/// </summary>
public class Solution
{
    public int LongestValidParentheses(string s)
    {
        int maxLen = 0;
        Stack<int> stack = new();
        stack.Push(-1);
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(i);
            }
            else
            {
                stack.Pop();
                if (stack.Count == 0)
                {
                    stack.Push(i);
                }
                else
                {
                    maxLen = i - stack.Peek();
                }
            }
        }

        return maxLen;
    }
}