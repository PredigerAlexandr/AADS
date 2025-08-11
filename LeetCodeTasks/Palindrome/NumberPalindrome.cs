namespace Polindrom;

public static class NumberPalindrome
{
    public static bool NumberPalindromeImplementation(int x)
    {
        if (x < 0)
        {
            return false;
        }

        var beginNumber = x;
        var palindrome = 0;

        while (beginNumber > 0)
        {
            var ostatok = beginNumber % 10;
            palindrome = (palindrome * 10) + ostatok;
            beginNumber = beginNumber / 10;
        }

        return x == palindrome;
    }
}