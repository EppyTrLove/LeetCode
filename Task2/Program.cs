using Microsoft.VisualBasic;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    { 

         static string LongestCommonPrefix(string[] strs)
        {
            string longest = "";
            int index = 0;
            if (strs == null || strs.Length == 0)
            {
                return longest;
            }
            // go through each letter
            for (int i = 0; i < strs[0].Length; i++)
            {
                // go through each element and check for letter
                for (int j = 1; j < strs.Length; j++)
                {
                    // handles out of bounds case and checks if character is same in all elements
                    if (index >= strs[j].Length || strs[0][index] != strs[j][index])
                    {
                        return longest;
                    }
                }
                longest += strs[0][index];
                index++;
            }
            return longest;
        }
    }
}











