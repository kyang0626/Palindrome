using System;
namespace Palindrome
{
    public class Exceptions
    {
        public Exceptions()
        {
            int a = 1;
            int b = 0;

            int c;
            try
            {
                c = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                c = 0;
            }
            Console.WriteLine(c);
        }
    }
}
