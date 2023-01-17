using System;
using System.Globalization;
using System.Numerics;


class Progrqam
{
    public static void Main(string[] args)
    { 
    
       static int[] PlusOne(int[] digits)
        {
            //var arr = new int[digits.Length +1];
            //for (var i = 0; i < digits.Length - 1; i++)
            //{
            //    {
            //        if (digits[i] != 9)
            //        {
            //            arr[i] = digits[i];
            //            digits.SetValue(digits.Last(), digits.Last() + 1);
            //        }
            //        else if (digits[i] == 9)
            //        {
            //            arr[i] = 1;
            //            arr[i + 1] = 0;
            //        }
            //    }
            //}
            //return arr;

            //digits.SetValue(digits.Last(), digits.Last() + 1);

            //string result = "";
            //foreach(var i in digits)
            //{
            //    result += i;
            //}
            //return result.ToArray();
            var str = digits.ToString();
            str.Last() +=
            string result = "";
            for (var i = 0; i < digits.Length - 1; i++)
            {
                if (digits[i] != 9)
                    result += digits[i];
                else if (digits[i] == 9)
                    result += "10";
            }
            var arr = new[] {result.Length+1};
            foreach(var i in result)
            {
                arr[i] = result[i];
            }
            return arr;
        }
        
        foreach(var i in PlusOne(new int[] { 1, 2, 3 }))
            Console.WriteLine(i);
    }
}