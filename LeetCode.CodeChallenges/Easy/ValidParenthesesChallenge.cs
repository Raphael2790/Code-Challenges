namespace LeetCode.CodeChallenges.Easy;

public class ValidParenthesesChallenge
{
    public bool IsValid(string s)
    {
        Stack<char> charStack = new();

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (c == '(' || c == '{' || c == '[')
                charStack.Push(c);

            if(c == ')' || c == '}' || c == ']')
            {
                if(charStack.Count == 0)
                    return false;

                char charOnTop = charStack.Pop();
                if (!IsCorrespondent(charOnTop, c))
                    return false;
                
            }
        }

        return charStack.Count == 0;
    }

    public static bool IsCorrespondent(char onStack, char actual) 
    {
        return (onStack is '{' && actual is '}')
            || (onStack is '[' && actual is ']')
            || (onStack is '(' && actual is ')');
    }
}
