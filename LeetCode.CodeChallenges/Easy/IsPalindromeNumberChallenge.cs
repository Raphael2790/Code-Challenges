namespace LeetCode.CodeChallenges.Easy;

public class IsPalindromeNumberChallenge
{
    public bool IsPalindrome(int x)
    {
        var stringNumber = x.ToString();
        var newString = string.Empty;
        var tamanho = stringNumber.Length;

        for (var index = 0; index < tamanho; index++)
        {
            newString += stringNumber[tamanho - index - 1];
        }

        return newString == stringNumber;
    }
}
