using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8csharpChallengeCLI
{
    class Program
    {
        // C# Challenge
        // Given input and output directory trees, write an application that will copy each text file from the input
        // to output directory, changing any dates in the input file from European style dates(yyyy/mm/dd) to
        // US dates(mm/dd/yyyy). Assume there can be any number of subdirectories in the input folder.

        static void Main(string[] args)
        {
            // Say Hello
            Console.WriteLine("Hello c8sciences - c# challenge!");

            // Acquire input for source and target folders
            Console.Write("Enter the name of the input directory:");
            string inputDirectory = Console.ReadLine();
            Console.Write("Enter the name of the output directory:");
            string outputDirectory = Console.ReadLine();


            // Prompt user to close the program.
            Console.WriteLine("Press ENTER to exit this program.");
            Console.ReadLine();
        }
    }
}
