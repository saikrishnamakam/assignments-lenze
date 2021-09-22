using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment2
{
    class Program
    {
        //Convert the time equivalent for the each city in file to India's time and add it in the third column of file
        public static bool ConvertToIndianTime(string filePath, Dictionary<string, string> cityTimeZoneIds, TimeZoneInfo indiaTimeZone)
        {
            string[] allLinesOfFile = File.ReadAllLines(filePath);

            string[] newLinesOfFile = new string[allLinesOfFile.Length];
            newLinesOfFile[0] = allLinesOfFile[0];

            for (int i = 1; i < allLinesOfFile.Length; i++)
            {
                string[] splittedLine = allLinesOfFile[i].Split(",");

                DateTime cityDateTime;
                bool isCityDateTimeParsed = DateTime.TryParse(splittedLine[1], out cityDateTime);

                if (isCityDateTimeParsed)
                {
                    string cityName = splittedLine[0];
                    string timeZoneId = cityTimeZoneIds.GetValueOrDefault(cityName, "");
                    TimeZoneInfo cityTimeZone;

                    if (timeZoneId != "")
                    {
                        try
                        {
                            //Finds the Time Zone of the country by id
                            cityTimeZone = TimeZoneInfo.FindSystemTimeZoneById(string.Format("{0} Standard Time", timeZoneId));
                        }
                        catch (TimeZoneNotFoundException)
                        {
                            Console.WriteLine("Unable to retrieve the city {0} Standard time zone.", cityName);
                            return false;
                        }
                        catch (InvalidTimeZoneException)
                        {
                            Console.WriteLine("Unable to retrieve the city {0} Standard time zone.", cityName);
                            return false;
                        }

                        //Converts the datetime object from source time zone to destination time zone in the specified format
                        string indiaDateTime = TimeZoneInfo.ConvertTime(cityDateTime, cityTimeZone, indiaTimeZone)
                            .ToString("HH:mm:ss tt");

                        newLinesOfFile[i] = cityName + "," + cityDateTime.ToString("HH:mm:ss tt") + "," + indiaDateTime;
                    }
                    else
                    {
                        Console.WriteLine("Unable to retrieve the city {0} Standard time zone.", cityName);
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("City Time(GMT) - {0} is given in incorrect format!", splittedLine[1]);
                    return false;
                }
            }

            File.WriteAllLines(filePath, newLinesOfFile);
            return true;
        }

        static void Main(string[] args)
        {
            string filePath = @"../../../Data.csv";

            //Mapping of each city with their equivalent time zone id
            Dictionary<string, string> cityTimeZoneIds = new Dictionary<string, string>()
            {
                {"Australia", "Cen. Australia"},
                {"Denmark", "Central Europe"},
                {"Brazil", "Central Brazilian"},
                {"Bhutan", "SE Asia"},
                {"France", "W. Europe"},
                {"Egypt", "Egypt"},
                {"London", "GMT"}
            };

            TimeZoneInfo indiaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");

            if (ConvertToIndianTime(filePath, cityTimeZoneIds, indiaTimeZone))
            {
                Console.WriteLine("Successfully Converted the time equivalent for that country to India's time!");
            }
            else
            {
                Console.WriteLine("Failed to Convert the time equivalent for that country to India's time!");
            }
        }
    }
}
