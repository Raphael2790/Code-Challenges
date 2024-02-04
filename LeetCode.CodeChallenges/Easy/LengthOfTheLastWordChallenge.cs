namespace LeetCode.CodeChallenges.Easy;

public class LengthOfTheLastWordChallenge
{
    public int LengthOfLastWord(string s)
    {
        string[] stringArray = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        return stringArray.Last().Length;
    }
}
