using System;

namespace IntegerLoop
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Print even integers from 0 to 50.
            for (int i = 0; i < 51; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
