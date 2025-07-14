using System.Collections.Frozen;

namespace source._0000._17;

/// <summary>
///     <a href="https://leetcode.cn/problems/letter-combinations-of-a-phone-number">
///         Letter Combinations of a Phone Number
///     </a>
/// </summary>
public class Solution
{
    private static readonly IDictionary<char, char[]> DigitToChars = new Dictionary<char, char[]>
    {
        { '2', ['a', 'b', 'c'] },
        { '3', ['d', 'e', 'f'] },
        { '4', ['g', 'h', 'i'] },
        { '5', ['j', 'k', 'l'] },
        { '6', ['m', 'n', 'o'] },
        { '7', ['p', 'q', 'r', 's'] },
        { '8', ['t', 'u', 'v'] },
        { '9', ['w', 'x', 'y', 'z'] }
    }.ToFrozenDictionary();

    public IList<string> LetterCombinations(string digits)
    {
        if (digits.Length == 0)
        {
            return [];
        }

        IList<string> combinations = new List<string> { "" };
        IEnumerable<char[]> digitChars = digits.Select(digit => DigitToChars[digit]);
        foreach (IList<string> addCombinations in digitChars.Select(ToCombinations))
        {
            combinations = addCombinations;
        }

        return combinations.ToList();

        IList<string> ToCombinations(char[] chars)
        {
            return (from combination in combinations
                    from c in chars
                    select combination + c).ToList<string>();
        }
    }
}