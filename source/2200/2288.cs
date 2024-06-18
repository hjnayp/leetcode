namespace source._2200._2288;

public class Solution
{
    public string DiscountPrices(string sentence, int discount)
    {
        string[] words = sentence.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (TryGetPrice(words[i], out double price))
            {
                words[i] = $"${(price * (100 - discount) / 100):F2}";
            }
        }

        return string.Join(' ', words);


        bool TryGetPrice(string word, out double price)
        {
            price = 0;
            if (word[0] != '$') return false;
            if (word.Length < 2) return false;

            for (int i = 1; i < word.Length; i++)
            {
                int digit = word[i] - '0';
                if (digit is < 0 or > 9) return false;
                price = price * 10 + digit;
            }

            return true;
        }
    }
}