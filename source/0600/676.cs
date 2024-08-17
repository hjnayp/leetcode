namespace source._0600._676;

public class MagicDictionary
{
    private class Trie
    {
        public IList<Trie?> Children { get; } = new Trie[26];

        public bool IsEnd { get; private set; }

        public void Add(string word)
        {
            Trie root = this;
            foreach (int index in word.Select(ch => ch - 'a'))
            {
                root.Children[index] ??= new Trie();
                root = root.Children[index];
            }

            root.IsEnd = true;
        }
    }

    private Trie _trie = new();

    public void BuildDict(string[] dictionary)
    {
        _trie = new Trie();
        foreach (string word in dictionary)
        {
            _trie.Add(word);
        }
    }

    public bool Search(string searchWord)
    {
        return DfsSearch(_trie, 0, false);

        bool DfsSearch(Trie? trie, int pos, bool isModified)
        {
            if (trie is null)
            {
                return false;
            }

            bool isLastChar = pos == searchWord.Length;
            if (isLastChar)
            {
                return isModified && trie.IsEnd;
            }

            int index = searchWord[pos] - 'a';
            if (DfsSearch(trie.Children[index], pos + 1, isModified))
            {
                return true;
            }

            if (isModified)
            {
                return false;
            }

            for (int i = 0; i < 26; ++i)
            {
                if (i != index && DfsSearch(trie.Children[i], pos + 1, true))
                {
                    return true;
                }
            }

            return false;
        }
    }
}