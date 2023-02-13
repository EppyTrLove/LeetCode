using System;
using System.Globalization;
using System.Numerics;
class Program
{
    public static void Main(string[] args)
    { }
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            var arr =s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return arr[arr.Length-1].Length;
        }
    }
    }
}