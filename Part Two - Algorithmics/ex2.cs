using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_Two___Algorithmics
{
    class ex2
    {
        public static bool IsSortedPalindrome(string input)
        {
            int length = input.Length;
            int mid = length / 2;

            for (int i = 0; i <= mid; i++)
            {
                if (input[i] != input[length - i - 1])
                    return false;

                if (i > 0 && input[i] < input[i - 1])
                    return false;
            }

            return true;
        }

        //private static void Main(string[] args)
        //{
        //    Console.WriteLine(IsSortedPalindrome("אבגדגבא"));
        //    Console.WriteLine(IsSortedPalindrome("שוש"));
        //    Console.WriteLine(IsSortedPalindrome("1234321"));
        //    Console.WriteLine(IsSortedPalindrome("1221"));
        //    Console.WriteLine(IsSortedPalindrome("abccba"));
        //    Console.WriteLine(IsSortedPalindrome("acbca"));
        //}
    }
   
}
