using System.Text;

namespace source._2100._2129;

public class Solution
{
    public string CapitalizeTitle(string title)
    {
        string[] words = title.Split(' ');
        var sb = new StringBuilder();
        foreach (string word in words)
        {
            if (word.Length <= 2)
            {
                sb.Append(word.ToLower());
            }
            else
            {
                string newWord = word.ToLower();
                newWord = char.ToUpper(newWord[0]) + newWord[1..];
                sb.Append(newWord);
            }

            sb.Append(' ');
        }

        return sb.ToString().Trim();
    }
}