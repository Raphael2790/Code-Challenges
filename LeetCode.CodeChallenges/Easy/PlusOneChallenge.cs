namespace LeetCode.CodeChallenges.Easy;

public class PlusOneChallenge
{
    public int[] PlusOne(int[] digits)
    {
        string stringNumber = string.Join("", digits);

        int[] newDigits;

        int plusNumber = 1; 

        if (digits.All(d => d == 9))
            newDigits = new int[stringNumber.Length + 1];
        else
            newDigits = new int[stringNumber.Length];

        for (int i = stringNumber.Length -1 ; i < stringNumber.Length; i--)
        {
            if (i < 0)
                break;

            int sum = int.Parse(stringNumber[i].ToString()) + plusNumber;

            if(sum == 10)
            {
                newDigits[i] = 0;
            }
            else
            {
                newDigits[i] = sum;
                plusNumber = 0;
            }
        }

        if(plusNumber == 1)
            newDigits[0] = plusNumber;

        return newDigits;
    }
}
