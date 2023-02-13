using System;
using System.Globalization;
using System.Text;
class Program
{
    public static void Main(string[] args)
    {
        static int SearchInsert(int[] nums, int target)
    {
            var result = Array.IndexOf(nums, target);
            if (result == -1)
                for (var i = 0; i < nums.Length; i++)
                    if (target < nums[0])
                        result = 0;
                    else if (target > nums[i])
                        result = i + 1;
            return result;

            //var low = 0;
            //var mid = 0;
            //int guess = 0;
            //var high = nums.Length - 1;
            //while (low <= high)
            //{
            //    mid = (low + high) / 2;
            //    guess = nums[mid];
            //    if (guess == target)
            //        return mid;
            //    if (guess > target)
            //        high = mid - 1;
            //    else low = mid + 1;                
            //}
            //return guess;

        }

        var nums = new[] { 0, 1, 2, 4, 7, 9 };

        Console.WriteLine(SearchInsert(nums, 5));

    }
}
