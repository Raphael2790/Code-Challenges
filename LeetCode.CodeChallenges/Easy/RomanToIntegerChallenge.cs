namespace LeetCode.CodeChallenges.Easy;

public class RomanToIntegerChallenge
{
    //Versão com menos uso de memoria porem mais lenta que usando dicionario
    public static int RomanToInt(string s)
    {
        var result = 0;
        var last = 0;
        foreach (var c in s)
        {
            var current = GetRomanValue(c);
            if (current > last)
            {
                result -= last;
                result += current - last;
            }
            else
            {
                result += current;
            }

            last = current;
        }

        return result;
    }

    private static int GetRomanValue(char c)
    {
        return c switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => throw new ArgumentException($"Invalid roman character: {c}", nameof(c))
        };
    }
}
