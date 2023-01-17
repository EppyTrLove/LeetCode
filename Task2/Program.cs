using Microsoft.VisualBasic;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Progrqam
{
    public static void Main(string[] args)
    {
        static string LongestCommonPrefix(string[] strs)
        {
            //Напишите функцию для поиска самой длинной строки общего префикса среди массива строк.

            //Если общего префикса нет, верните пустую строку "".

            //Пример 1:
            //Input: strs = ["flower", "flow", "flight"]
            //Output: "fl"

            //Пример 2:
            //Input: strs = ["dog", "racecar", "car"]
            //Output: ""
            //Explanation: There is no common prefix among the input strings.
            string s = "";
            //foreach (var str in strs) {

            for (var i = 0; i < strs.Length - 1; i++)
            {
                //for(var j = 0; j < strs.Length - 1; j++)
                if (strs[i].StartsWith(strs[i + 1][i]))
                {

                    s += strs[i][i];

                }
            }
            return s;
        }



        var s = new[] {"flower","flow","flight" };
        LongestCommonPrefix(s);
        Console.ReadKey();
        }
        }


        
    




        


