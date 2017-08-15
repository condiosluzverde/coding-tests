﻿using System;
using System.IO;

using WinFileUtils;

// C# Challenge
// Given input and output directory trees, write an application that will copy each text file from the input
// to output directory, changing any dates in the input file from European style dates(yyyy/mm/dd) to
// US dates(mm/dd/yyyy). Assume there can be any number of subdirectories in the input folder.

namespace TreeTestCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Say Hello
            Console.WriteLine("Hello c8sciences - c# challenge");

            // Acquire input for source and target folders
            Console.Write("Enter the name of the input directory:");
            string inputDirectory = Console.ReadLine();
            Console.Write("Enter the name of the output directory:");
            string outputDirectory = Console.ReadLine();

            CLIResult result = Process(inputDirectory, outputDirectory);

            // Prompt user to close the program.
            Console.WriteLine("Press ENTER to exit this program.");
            Console.ReadLine();
        }

        public static CLIResult Process(string inputName, string outputName)
        {
            CLIResult result = new CLIResult();

            try
            {
                
            }
            catch(Exception ex)
            {
                result.StatusCode = -1;
                result.StatusMessage = ex.Message;
            }
            finally
            {

            }

            return result;
        }

        public class CLIResult
        {
            public int StatusCode = -1;
            public string StatusMessage = "unknown";
        }
    }
}
