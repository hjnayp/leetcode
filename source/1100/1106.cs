namespace source._1100._1106;

/// <summary>
///     <a href="https://leetcode.cn/problems/parsing-a-boolean-expression">
///         Parsing A Boolean Expression
///     </a>
/// </summary>
public class Solution
{
    public bool ParseBoolExpr(string expression)
    {
        Stack<char> expStack = new();
        foreach (char c in expression)
        {
            switch (c)
            {
                case ',':
                case '(':
                    break;

                case ')':
                    CalculateExpression();
                    break;

                default:
                    expStack.Push(c);
                    break;
            }
        }

        return expStack.Peek() == 't';

        void CalculateExpression()
        {
            List<char> bools = [];

            while (expStack.Peek() != '!' && expStack.Peek() != '&' && expStack.Peek() != '|')
            {
                bools.Add(expStack.Pop());
            }

            char op = expStack.Pop();
            bool res = false;
            switch (op)
            {
                case '|':
                    res = bools.Any(b => b == 't');
                    break;

                case '&':
                    res = bools.All(b => b == 't');
                    break;

                case '!':
                    res = bools[0] == 'f';
                    break;
            }

            expStack.Push(res ? 't' : 'f');
        }
    }
}