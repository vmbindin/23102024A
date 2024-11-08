using System;

namespace CommandLineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string? option = null;
            string? input = null;
		
	    if (args.Length <= 1)
            {
		Console.WriteLine("Usage: program -option <input>");
		return;
	    }

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-option")
                {
                    option = args[i + 1];
                }
                else
                {
                    input = args[i];
		    break;
                }
            }

            Console.WriteLine($"Option: {option}");
            Console.WriteLine($"Input: {input}");
            // Add your logic here
        }
    }
}