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

            var array = new char[word.Length];

            for (int i = word.Length; i > 0; i--)
            {
                array[word.Length - i] = word[i - 1];
            }
            string reversed = new string(array);
            //Console.WriteLine(reversed);

            if (word == reversed)
            {
                Console.WriteLine("This is a palindrome");
            }
            else
            {
                Console.WriteLine("This is not a palindrome");
            }

           
        }


        
    }
}
