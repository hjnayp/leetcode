#pragma once

#include <vector>
#include <unordered_map>
#include <algorithm>

namespace source_2080
{
    using namespace std;

    class RangeFreqQuery
    {
    public:
        explicit RangeFreqQuery(vector<int>& arr)
        {
            for (int i = 0; i < arr.size(); ++i)
            {
                _numToPoses[arr[i]].push_back(i);
            }
        }

        int query(int left, int right, int value)
        {
            const auto& poses = _numToPoses[value];
            const auto l = ranges::lower_bound(poses, left);
            const auto r = ranges::upper_bound(poses, right);
            return r - l;
        }

    private:
        unordered_map<int, vector<int>> _numToPoses;
    };
}
