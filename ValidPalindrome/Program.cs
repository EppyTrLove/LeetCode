using System;
using System.Globalization;
using System.Numerics;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
    }

    public static bool IsPalindrome(string s)
    {
        //char[] charsToTrim = { '*', ' ', '\'', '-', '+', ',', '.', '?', '!', '\t', '\n', ':', ';', '1', '2', '3','4','5',
        //'6', '7', '8', '9', '0'};
        //Console.WriteLine(s.ToLower().Trim(charsToTrim).Reverse());
        //return s.ToLower().Trim(charsToTrim) == s.ToLower().Trim(charsToTrim).Reverse();
        var sequence = string.Concat(s.ToLower().Where(char.IsLetterOrDigit));
        return sequence.SequenceEqual(sequence.Reverse());
    }
}
