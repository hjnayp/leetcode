namespace source._0700._721;

public class Solution
{
    private class UnionFind
    {
        private IList<int> _parent;

        public UnionFind(int n)
        {
            _parent = new int[n];
            for (int i = 0; i < n; i++)
            {
                _parent[i] = i;
            }
        }

        public void Union(int x, int y)
        {
            _parent[Find(x)] = Find(y);
        }

        public int Find(int idx)
        {
            if (_parent[idx] != idx)
            {
                _parent[idx] = Find(_parent[idx]);
            }

            return _parent[idx];
        }
    }

    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
    {
        IDictionary<string, int> emailToIdx = new Dictionary<string, int>();
        IDictionary<string, string> emailToName = new Dictionary<string, string>();

        int mailsCnt = 0;
        foreach (IList<string> account in accounts)
        {
            string name = account[0];
            int size = account.Count;
            for (int i = 1; i < size; i++)
            {
                string email = account[i];
                if (emailToIdx.ContainsKey(email)) continue;
                emailToIdx.Add(email, mailsCnt++);
                emailToName.Add(email, name);
            }
        }

        UnionFind unionFind = new(mailsCnt);
        foreach (IList<string> account in accounts)
        {
            int firstEmailIdx = emailToIdx[account[1]];
            for (int i = 1; i < account.Count; ++i)
            {
                int nextEmailIdx = emailToIdx[account[i]];
                unionFind.Union(firstEmailIdx, nextEmailIdx);
            }
        }

        IDictionary<int, IList<string>> idxToEmails = new Dictionary<int, IList<string>>();
        foreach ((string email, int mailIdx) in emailToIdx)
        {
            int idx = unionFind.Find(mailIdx);

            if (!idxToEmails.TryGetValue(idx, out IList<string>? value))
            {
                value = new List<string>();
                idxToEmails.Add(idx, value);
            }

            value.Add(email);
        }

        IList<IList<string>> mergedAccounts = new List<IList<string>>();
        foreach ((int idx, IList<string>? emails) in idxToEmails)
        {
            string name = emailToName[emails[0]];
            string[] emailArr = emails.ToArray();
            Array.Sort(emailArr, StringComparer.Ordinal);
            IList<string> account = [name, ..emailArr];
            mergedAccounts.Add(account);
        }

        return mergedAccounts;
    }
}