namespace source._0000._22;

/// <summary>
///     <a href="https://leetcode.cn/problems/generate-parentheses">Link</a>
/// </summary>
public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        IList<string> parenthesis = new List<string>();
        GenerateParentheses("", 0, 0);
        return parenthesis;

        void GenerateParentheses(string parentheses, int left, int right)
        {
            if (parentheses.Length == n * 2)
            {
                parenthesis.Add(parentheses);
                return;
            }

            if (left < n)
            {
                GenerateParentheses(parentheses + "(", left + 1, right);
            }

            if (right < left)
            {
                GenerateParentheses(parentheses + ")", left, right + 1);
            }
        }
    }
}