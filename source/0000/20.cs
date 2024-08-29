namespace source._0000._20;

/// <summary>
///     <a href="https://leetcode.cn/problems/valid-parentheses">Link</a>
/// </summary>
public class Solution
{
    private static readonly IDictionary<char, char> ParenthesesPair = new Dictionary<char, char>
    {
        { ')', '(' },
        { ']', '[' },
        { '}', '{' }
    };

    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        return s.All(CanStackMatchParentheses) && stack.Count is 0;

        bool CanStackMatchParentheses(char parentheses)
        {
            if (parentheses is ')' or ']' or '}' &&
                stack.Count > 0 &&
                stack.Peek() == ParenthesesPair[parentheses])
            {
                stack.Pop();
                return true;
            }

            stack.Push(parentheses);
            return true;
        }
    }
}
