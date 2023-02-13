using System;
using System.Text;
class Program
{
    public static void Main(string[] args)
    {
        static int RemoveElement(int[] nums, int val)
        {
            var count = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            return count;
        }

        var nums = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };

        Console.WriteLine(RemoveElement(nums, 2)); 
        
    }
}


    
