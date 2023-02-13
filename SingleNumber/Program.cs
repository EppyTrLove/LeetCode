using System;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.Numerics;


class Program
{
    public static void Main(string[] args)
    {
        var arr1 = new[] { 2, 2, 1};

        Console.WriteLine(SingleNumber(arr1));


    }

    public static int SingleNumber(int[] nums)
    {
        int result = 0;
        foreach (var num in nums)
            result ^= num;
        return result;

    }
}

