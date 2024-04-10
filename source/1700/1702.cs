using System.Text;

namespace source._1700._1702;

public class Solution
{
    public string MaximumBinaryString(string binary)
    {
        var res = new StringBuilder();
        var idx = 0;
        for (var i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '0')
            {
                idx = i;
                break;
            }

            res.Append(binary[i]);
        }

        var zeroNum = 0;
        for (int i = idx; i < binary.Length; ++i)
            if (binary[i] == '0')
                zeroNum++;

        if (zeroNum < 2) return binary;
        for (int i = idx; i < binary.Length; i++)
            res.Append(i == idx + zeroNum - 1 ? '0' : '1');
        return res.ToString();
    }
}