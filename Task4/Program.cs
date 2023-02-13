using Microsoft.VisualBasic;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        static bool IsPalindrome(int x)
        {
            return x.ToString().SequenceEqual(x.ToString().Reverse());

            //    bool result = false;
            //    var str = x.ToString().Reverse();
                
            //    Console.WriteLine(str);
            //    if (x < 0)
            //        result = false;
            //    else if (x.ToString().Equals(str))
            //    {
            //        result = true;
            //    }
                
            //return result;

            //if (x < 0)
            //    return false;
            //else if (x.ToString().ToCharArray. == x.ToString().ToCharArray().Reverse());
            //return true;
        }
        Console.WriteLine(IsPalindrome(121));
        Console.ReadLine();
    }
    }

