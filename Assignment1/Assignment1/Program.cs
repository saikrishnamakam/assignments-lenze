using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Assignment1
{
    class Program
    {
        static void ReplaceMatchedStringFromFile(string findString, string replaceString, int noOfStringOccurrences, string filePath)
        {
            string fileText = File.ReadAllText(filePath);

            Regex regex = new Regex(findString);
            string modifiedFileText = regex.Replace(fileText, replaceString, noOfStringOccurrences);

            File.WriteAllText(filePath, modifiedFileText);
        }

        static void Main(string[] args)
        {
            string filePath = @"../../../../Assignment1/samplefile.txt";

            if (File.Exists(filePath))
            {
                Console.WriteLine("Find String: ");
                string findString = Console.ReadLine();

                Console.WriteLine("Replace String: ");
                string replaceString = Console.ReadLine();

                Console.WriteLine("No. of occurrences to replace: ");
                int noOfStringOccurrences = int.Parse(Console.ReadLine());

                ReplaceMatchedStringFromFile(findString, replaceString, noOfStringOccurrences, filePath);

                Console.WriteLine("File is successfully updated!");
            }
            else
            {
                Console.WriteLine("File not found, Please check the provided path again.");
            }
        }
    }
}
