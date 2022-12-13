using System;

namespace Dear_Santa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int spaces = 10;
            int asterix = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < asterix; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                asterix++;
                spaces--;

               
            }
            Console.WriteLine("Dear Santa, since I've been good this year, and I'm doing well in school, would you please give me a keyboard?");
        }
    }
}
