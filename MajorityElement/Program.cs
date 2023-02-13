using System;
using System.Globalization;
using System.Numerics;


class Program
{
    public static void Main(string[] args)
    {
        var nums = new[] { 1, 2, 3, 5, 5, 5, 5, 5, };
        MajorityElement(nums);
    }

        public static int MajorityElement(int[] nums)
        {

            var result = 0;
            var dict = new Dictionary<int, int>();
            foreach (var i in nums)
            {
                // When the key is not found, "count" will be initialized to 0
                dict.TryGetValue(i, out int count);
                dict[i] = count + 1;
            }
            foreach (var pair in dict)
            {
                Console.WriteLine(pair);
                if (pair.Value > nums.Length / 2)
                    result = pair.Key;
            }
            return result;
        }
   
    //    var count = 0;
    //    var result = 0;
    //    if(nums.Length == 0)
    //    {
    //        result = 0;
    //    }
    //    for(var i = 0; i < nums.Length; i++)
    //    {
    //        for(var j = i + 1; j < nums.Length; j++)
    //        {
    //            if (nums[i] == nums[j])
    //            {
    //                result += nums[i];
    //                count++;
    //                if (count > nums.Length / 2)
    //                    break;
    //            }
    //        }

    //    }
    //    if (count > nums.Length / 2)
    //        result /= count;
    //return result;
}
    


