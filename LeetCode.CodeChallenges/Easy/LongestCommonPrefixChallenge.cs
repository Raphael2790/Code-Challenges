namespace LeetCode.CodeChallenges.Easy;

public class LongestCommonPrefixChallenge
{
    public string LongestCommonPrefix(string[] strs)
    {
        int index = 0;
        string validPrefix = string.Empty;
        string firstString = strs[0];
        bool continueSearch = true;

        while (index < firstString.Length && continueSearch)
        {
            string prefix = firstString[..(index+1)];

            var valid = strs.All(x => x.StartsWith(prefix));

            if(valid)
                validPrefix = prefix;
            else
                break;

            index++;
        }
        
        return validPrefix;
    }
}
