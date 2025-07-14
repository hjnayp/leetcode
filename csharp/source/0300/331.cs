using System.Collections;

namespace source._0300._331;

public class Solution
{
    public bool IsValidSerialization(string preorder)
    {
        string[] vals = preorder.Split(",");
        var slots = 1;
        foreach (string val in vals)
        {
            if (slots == 0) return false;
            if (val == "#")
            {
                --slots;
            }
            else
            {
                --slots;
                slots += 2;
            }
        }

        return slots == 0;
    }
}