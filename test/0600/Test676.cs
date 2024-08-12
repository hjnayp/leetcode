using JetBrains.Annotations;
using source._0600._676;

namespace test._0600;

[TestClass]
[TestSubject(typeof(MagicDictionary))]
public class Test676
{
    [TestMethod]
    public void CommonCase()
    {
        CreateTestSuit(
            [[], ["hello", "leetcode"], ["hello"], ["hhllo"], ["hell"], ["leetcode"]],
            [null, null, false, true, false, false]
        );

        CreateTestSuit(
            [[], ["hello", "hallo", "leetcode"], ["hello"], ["hhllo"], ["hell"], ["leetcoded"]],
            [null, null, true, true, false, false]
        );
        
        CreateTestSuit(
            [[], ["hello", "hallo", "leetcode"], ["hello"], ["hallo"], ["hell"], ["leetcodd"]],
            [null, null, true, true, false, true]
        );      
    }

    [TestMethod]
    public void TestNotPassCase()
    {

        CreateTestSuit(
            [[], ["hello","hallo","leetcode","judge"], ["hello"], ["hallo"], ["hell"], ["leetcodd"], ["judge"]],
            [null,null,true,true,false,true,false]
        );
    }


    private void CreateTestSuit(string[][] parameters, bool?[] results)
    {
        MagicDictionary dictionary = new();
        dictionary.BuildDict(parameters[1]);

        for (int i = 2; i < parameters.Length; i++)
        {
            string[] word = parameters[i];
            bool? result = results[i];
            Assert.AreEqual(result, dictionary.Search(word[0]));
        }
    }
}