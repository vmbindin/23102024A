using System;

namespace CommandLineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string? option = null;
            string? input = null;

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-option")
                {
                    option = args[i + 1];
                    i++; // Skip the next argument as it's the value for -option
                }
                else
                {
                    input = args[i];
                }
            }

            if (option == null || input == null)
            {
                Console.WriteLine("Usage: program -option <input>");
                return;
            }

            Console.WriteLine($"Option: {option}");
            Console.WriteLine($"Input: {input}");
            // Add your logic here
        }
    }
}