using System;
using System.Globalization;
using System.Numerics;


class Program
{
    public static void Main(string[] args)
    { }
    public class Solution
    {
        public int MySqrt(int x)
        {
                int result = 0;
                int a = 1;
                while (a <= x)
                {
                    x -= a;
                    a += 2;
                    result++;
                }
                return result;
        }
    }
}