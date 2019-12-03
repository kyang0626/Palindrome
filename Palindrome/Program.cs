using System;
using System.Collections;

namespace Palindrome
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();

            
            palindromeCheck(word);
           
        }

        public static string palindromeCheck(string x)
        {
            var array = new char[x.Length];

            for (int i = x.Length; i > 0; i--)
            {
                array[x.Length - i] = x[i - 1];
            }
            string reversed = new string(array);
            //Console.WriteLine(reversed);

            if (x == reversed)
            {
                Console.WriteLine("This is a palindrome");
            }
            else
            {
                Console.WriteLine("This is not a palindrome");
            }
            return x;
        }


        
    }
}
