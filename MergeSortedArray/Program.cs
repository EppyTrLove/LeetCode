using System;
using System.Globalization;
using System.Numerics;


class Program
{
    public static void Main(string[] args)
    {
        var arr1 = new[] { 1, 2, 3, 4, 0, 0, 0, 0 };
        var arr2 = new[] { 1, 2, 3, 4 };
        Merge(arr1, 4, arr2, 4);
        foreach (var item in arr1)
        {
            Console.WriteLine(item);
        }
    }
   
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
        for (var i = 0; i < nums2.Length; i++)
            nums1[m + i] = nums2[i];
        Array.Sort(nums1);
    }

    }
