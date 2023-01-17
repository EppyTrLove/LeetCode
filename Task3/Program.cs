using Microsoft.VisualBasic;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Progrqam
{
    public static void Main(string[] args)
    {
        static int RemoveDuplicates(int[] nums)
        {
            //return nums.Distinct().Count();
            int insertIndex = 1;
            for (var i = 1; i < nums.Length; i++)
                if (nums[i - 1] != nums[i])
                {
                    nums[insertIndex] = nums[i];
                    insertIndex++;
                }
            return insertIndex;
        }
        var arr = new[] { 1, 2, 2, 3, 3, 7, 8 };
        Console.WriteLine(RemoveDuplicates(arr));
        Console.ReadLine();
    }
   
    }

        
    

