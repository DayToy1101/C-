using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_9
{
    class Palindrome
    {
         static void Main()
        {
            System.Console.Write("please enter a palindrome: ");
            string palindrome = System.Console.ReadLine();
            Palindrome instance = new Palindrome();
            if (instance.IsPalindrome(palindrome))
            {
                System.Console.WriteLine("\"{0}\" is a palindrome.", palindrome);
                Console.Read();
            }
            else
            {
                System.Console.WriteLine("\"{0}\" is NOT a palindrome.", palindrome);
                Console.Read();
            }
        }
        public bool IsPalindrome(string text)
        {
            char[] temp;
            string reverse;
            reverse = text.Replace(" ", "");
            reverse = reverse.ToLower();
            temp = reverse.ToCharArray();
            System.Array.Reverse(temp);
            return reverse == new string(temp);
        }
    }

}
