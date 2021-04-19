using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Algorithms_and_Complexity___Antony_Scott
{
    class Program
    {
        static void Main(string[] args)
        {
            //file paths for all text documents
            string R1_256FilePath = @"C:\Users\Antony\Documents\C# Projects\Algorithms and Complexity - Antony Scott\bin\debug\netcoreapp3.1\Road_1_256.txt";
            string R2_256FilePath = @"C:\Users\Antony\Documents\C# Projects\Algorithms and Complexity - Antony Scott\bin\debug\netcoreapp3.1\Road_2_256.txt";
            string R3_256FilePath = @"C:\Users\Antony\Documents\C# Projects\Algorithms and Complexity - Antony Scott\bin\debug\netcoreapp3.1\Road_3_256.txt";
            string R1_2048FilePath = @"C:\Users\Antony\Documents\C# Projects\Algorithms and Complexity - Antony Scott\bin\debug\netcoreapp3.1\Road_1_2048.txt";
            string R2_2048FilePath = @"C:\Users\Antony\Documents\C# Projects\Algorithms and Complexity - Antony Scott\bin\debug\netcoreapp3.1\Road_2_2048.txt";
            string R3_2048FilePath = @"C:\Users\Antony\Documents\C# Projects\Algorithms and Complexity - Antony Scott\bin\debug\netcoreapp3.1\Road_3_2048.txt";

            //details the input at the beginning
            string input = "";
            
            //converts the text files from the file paths into lists which can then be printed and manipulated easier
            List<string> R1_256 = File.ReadAllLines(R1_256FilePath).ToList();
            List<string> R2_256 = File.ReadAllLines(R2_256FilePath).ToList();
            List<string> R3_256 = File.ReadAllLines(R3_256FilePath).ToList();

            List<string> R1_2048 = File.ReadAllLines(R1_2048FilePath).ToList();
            List<string> R2_2048 = File.ReadAllLines(R2_2048FilePath).ToList();
            List<string> R3_2048 = File.ReadAllLines(R3_2048FilePath).ToList();

            //prints the introduction and then asks 
            Console.WriteLine("Welcome to my algorithms and complexity program! Press enter to continue.");
            Console.ReadLine();
            /*do
            {
                Console.WriteLine("Please choose a road data set to view, the options are 1, 2 or 3. Or type Q to quit the program. ");
                input = Console.ReadLine();
                if (!input.ToUpper().Equals("Q"))
                {
                    int number = 0;
                    if (int.TryParse(input, out number))
                    {
                        if (number >= 1 && number <= 1)
                        {
                            string[] readText = File.ReadAllLines(R1_256FilePath);
                            foreach (string s in readText)
                            {
                                Console.WriteLine(s);
                            }
                            Console.ReadLine();
                        }
                        if (number >= 2 && number <= 2)
                        {
                            string[] readText = File.ReadAllLines(R2_256FilePath);
                            foreach (string s in readText)
                            {
                                Console.WriteLine(s);
                            }
                            Console.ReadLine();
                        }
                        if (number >= 3 && number <= 3)
                        {
                            string[] readText = File.ReadAllLines(R3_256FilePath);
                            foreach (string s in readText)
                            {
                                Console.WriteLine(s);
                            }
                            Console.ReadLine();
                        }
                        else
                            Console.WriteLine("Please enter 1, 2 or 3. Or press Q to exit the program.");
                    }
                }
            }while (!input.ToUpper().Equals("Q"));*/

            Console.WriteLine("Please choose a road data set to view, the options are 1, 2 or 3.");
            Console.ReadLine();
            input = Console.ReadLine();
            int number = 0;

            if (int.TryParse(input, out number))
            {
                if (number >= 1 && number <= 1)
                {
                    
                }
            }
            


        }
    }
}