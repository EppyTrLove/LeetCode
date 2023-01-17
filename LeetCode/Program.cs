using System;
using System.Globalization;
using System.Numerics;


class Progrqam
{
    public static void Main(string[] args)
    { }
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            // string str;
            // foreach (int x in nums)
            //     if (nums.Contains(target - x)&& 
            //         str.add(Array.IndexOf(nums, x));    


            //}
            //var list = new List<int>();
            //foreach (int x in nums)
            //{
            //    if (nums.Contains(target - x)){
            //        list.Add(Array.IndexOf(nums, x));
            //        list.Add(Array.IndexOf(nums, target - x));
            //    }
            //}

            var list = new List<int>();
            for (var i = 0; i < nums.Length - 1; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                    if (nums[i] + nums[j] == target)
                    {
                        list.Add(i);
                        list.Add(j);
                    }
            }
            return list.Distinct().ToArray();
        }
    }
}
