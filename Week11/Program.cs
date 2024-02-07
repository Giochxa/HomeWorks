using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using Newtonsoft.Json;

namespace Week11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //LastLine();
            //multiplication("5");
            //XMLFile("programming", 2);
            //birthday();

            Console.WriteLine(FindFirstUniqueIndex("AABAB"));
            Console.WriteLine(CountPart("qwert wer we"));
        }


        #region Task 1
        static void LastLine()
        {
            var inputfilepath = @"C:\Users\george.chkhaidze\source\repos\Homework 2\Week11\text.txt";

            if (!File.Exists(inputfilepath))
            {
                // If the file doesn't exist, create it
                File.Create(inputfilepath).Close();
                Console.WriteLine("File created: " + inputfilepath);
            }
            Console.WriteLine("Please enter number of lines:");
            if (int.TryParse(Console.ReadLine(), out var n))
            {
                Console.WriteLine($"Please enter {n} lines:");

                for (int i = 0; i < n; i++)
                {
                    File.AppendAllText(inputfilepath, Console.ReadLine() + "\n");
                }

                Console.WriteLine("The last lines was:");
                Console.WriteLine(File.ReadLines(inputfilepath).LastOrDefault());
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                LastLine();
            }
        }
        #endregion
        #region Task 2
        static void multiplication(string input)
        {
            var multiFile = @"C:\Users\george.chkhaidze\source\repos\Homework 2\Week11\multi.txt";
            if (!File.Exists(multiFile))
            {
                // If the file doesn't exist, create it
                File.Create(multiFile).Close();
                Console.WriteLine("File created: " + multiFile);
            }

            //Console.WriteLine("Enter a positive integer:");
            //input = Console.ReadLine();

            if (!int.TryParse(input, out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input. Please provide a positive integer.");
                return;
            }

            //string filePath = @"C:\Users\george.chkhaidze\source\repos\Homework 2\Week11\multi.txt";

            using (StreamWriter sw = new StreamWriter(multiFile))
            {
                for (int i = 1; i <= 9; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        sw.Write($"{j} * {i} = {j * i} | ");
                    }
                    sw.WriteLine();
                }
            }

            Console.WriteLine($"Multiplication table for {n} has been written to {multiFile}");

        }
        #endregion
        #region Task 3
        static void XMLFile(string inputString, int n)
        {
            // Calculate the length of each part
            int partLength = (int)Math.Ceiling((double)inputString.Length / n);

            // Create an XML document
            XmlDocument xmlDoc = new XmlDocument();

            // Create the root element
            XmlElement rootElement = xmlDoc.CreateElement("root");
            xmlDoc.AppendChild(rootElement);

            // Divide the string into n parts and create XML nodes
            for (int i = 0; i < n; i++)
            {
                int startIndex = i * partLength;
                int endIndex = Math.Min((i + 1) * partLength, inputString.Length);
                string part = inputString.Substring(startIndex, endIndex - startIndex);

                // Create XML node for each part
                XmlElement node = xmlDoc.CreateElement($"{part.Substring(0, Math.Min(6, part.Length))}");
                node.InnerText = $"string {i + 1}";

                // Append the node to the root element
                rootElement.AppendChild(node);
            }

            // Save the XML document to a file
            xmlDoc.Save("C:\\Users\\george.chkhaidze\\source\\repos\\Homework 2\\Week11\\output.xml");

            Console.WriteLine("XML file with data has been created: output.xml");

        }

        #endregion
        #region Task4
        static void birthday()
        {
            // Read JSON data from file
            string jsonFilePath = @"C:\Users\george.chkhaidze\source\repos\Homework 2\Week11\birthday.json";
            string jsonData = File.ReadAllText(jsonFilePath);

            // Deserialize JSON data into a dynamic object
            dynamic json = JsonConvert.DeserializeObject(jsonData);

            // Extract date values
            DateTime currentDate = DateTime.Parse(json.currentDate.ToString());
            DateTime birthday = DateTime.Parse(json.birthday.ToString());

            // Calculate days left until the birthday
            TimeSpan timeUntilBirthday = birthday - currentDate;
            int daysLeft = timeUntilBirthday.Days;

            Console.WriteLine($"Current Date: {currentDate.ToString("MMMM dd, yyyy")}");
            Console.WriteLine($"Birthday: {birthday.ToString("MMMM dd, yyyy")}");
            Console.WriteLine($"Days left until the birthday: {daysLeft}");

        }
        #endregion

        #region Practice 1

        static int FindFirstUniqueIndex(string input)
        {
            Dictionary<char, int> charIndex = new Dictionary<char, int>();
            Dictionary<char, bool> isDuplicate = new Dictionary<char, bool>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (charIndex.ContainsKey(currentChar))
                {
                    isDuplicate[currentChar] = true;
                }
                else
                {
                    charIndex[currentChar] = i;
                    isDuplicate[currentChar] = false;
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (!isDuplicate[input[i]])
                {
                    return i;
                }
            }

            return -1;
        }

        #endregion
        #region Practice 2
        static int CountPart(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }

            string[] parts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return parts.Length;
        }
        #endregion
    }
}
