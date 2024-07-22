namespace source.Structs;

public class UnionFindSet
{
    private IList<int> _parent;

    public UnionFindSet(int n)
    {
        _parent = new int[n];
        for (int i = 0; i < n; i++)
        {
            _parent[i] = i;
        }
    }

    public void Union(int subSet, int mainSet)
    {
        _parent[Find(subSet)] = Find(mainSet);
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