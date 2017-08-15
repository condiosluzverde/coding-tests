using System;

namespace TreeTestCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello c8Test1!");

            Console.Write("Enter the name of the source directory:");
            string srcDirectory = Console.ReadLine();
            Console.Write("Enter the name of the target directory:");
            string targetDirectory = Console.ReadLine();



            Console.WriteLine("Press ENTER to exit this program.");
            Console.ReadLine();
        }
    }
}
