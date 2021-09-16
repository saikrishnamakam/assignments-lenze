using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Assignment1
{
    class Program
    {
        static void ReplaceMatched(string findString, string replaceString, int noOfStringOccurrences)
        {
            string filePath = @"C:\Check\samplefile.txt";

            Console.WriteLine(new FileInfo(filePath).Exists);
            if (File.Exists(filePath))
            {
                string fileText = File.ReadAllText(filePath);

                Regex regex = new Regex(findString);
                string modifiedFileText = regex.Replace(fileText, replaceString, noOfStringOccurrences);

                File.WriteAllText(filePath, modifiedFileText);
            }
            else
            {
                Console.WriteLine("File not found, Please check the provided path again.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Find String: ");
            string findString = Console.ReadLine();

            Console.WriteLine("Replace String: ");
            string replaceString = Console.ReadLine();

            Console.WriteLine("No. of occurrences to replace: ");
            int noOfStringOccurrences = int.Parse(Console.ReadLine());

            ReplaceMatched(findString, replaceString, noOfStringOccurrences);
        }
    }
}
