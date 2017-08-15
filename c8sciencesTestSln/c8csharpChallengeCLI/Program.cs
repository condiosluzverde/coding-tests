using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using c8sciencesFileManager;

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

            Process(inputDirectory, outputDirectory);

            // Prompt user to close the program.
            Console.WriteLine();
            Console.WriteLine("Press ENTER to exit this program.");
            Console.ReadLine();
            Console.WriteLine();
        }

        public static void Process(string input, string output)
        {
            bool continueProcessing = true;

            // show cwd
            Console.WriteLine();
            Console.WriteLine("Current Directory is: " + FSNode.GetCurrentDirectory());

            // validate arguments
            FSNode inputNode = new FSNode(input);
            if (!inputNode.IsValid())
            {
                Console.WriteLine();
                Console.WriteLine("Input directory is not valid: ({0})", input);
                Console.WriteLine("Stop.");
                continueProcessing = false;
            }
            FSNode outputNode = new FSNode(output);
            if (continueProcessing && !outputNode.IsValid())
            {
                Console.WriteLine();
                Console.WriteLine("Output directory is not valid: ({0})", output);
                Console.WriteLine("Stop.");
                continueProcessing = false;
            }

            if (continueProcessing)
            {
                Console.WriteLine();
                Console.WriteLine("Processing...");
                Console.WriteLine();
                Console.WriteLine("Result: {0}", inputNode.TreeCopy(outputNode));
            }

            if (continueProcessing)
            {
                Console.WriteLine();
                Console.WriteLine("Processing complete.");
            }
        }
    }
}
