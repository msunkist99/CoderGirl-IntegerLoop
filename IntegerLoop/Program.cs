using System;

namespace IntegerLoop
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Print even integers from 0 to 50.
            // note that zero is not an even number
            for (int i = 1; i < 51; i++)
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
