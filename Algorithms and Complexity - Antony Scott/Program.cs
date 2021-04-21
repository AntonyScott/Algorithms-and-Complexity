using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Algorithms_and_Complexity_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //the file paths for the txt files are declared below
            string R1_256FilePath = @"C:\Users\Antony\Documents\C# Projects\Algorithms and Complexity - Antony Scott\bin\debug\Road_1_256.txt";
            string R2_256FilePath = @"C:\Users\Antony\Documents\C# Projects\Algorithms and Complexity - Antony Scott\bin\debug\Road_2_256.txt";
            string R3_256FilePath = @"C:\Users\Antony\Documents\C# Projects\Algorithms and Complexity - Antony Scott\bin\debug\Road_3_256.txt";
            string R1_2048FilePath = @"C:\Users\Antony\Documents\C# Projects\Algorithms and Complexity - Antony Scott\bin\debug\Road_1_2048.txt";
            string R2_2048FilePath = @"C:\Users\Antony\Documents\C# Projects\Algorithms and Complexity - Antony Scott\bin\debug\Road_2_2048.txt";
            string R3_2048FilePath = @"C:\Users\Antony\Documents\C# Projects\Algorithms and Complexity - Antony Scott\bin\debug\Road_3_2048.txt";

            //the first input is declared as empty until the user decides
            string input = "";

            string A_or_D = "";

            //exactly how the input is coded, except this time its do decide whether to Ascend or Descend the data sets
            //string A_or_D = "";
            //A_or_D = Console.ReadLine();

            //the program then enters a do-while loop
            do
            {
                //asks the user to choose a data set to read
                Console.WriteLine("Please choose a road data set to view, the options are 1, 2, 3, 4, 5 and 6. Or quit the program. ");
                //how input is read into the console
                input = Console.ReadLine();
                if (!input.ToUpper().Equals("Q"))
                {
                    //saves the number the user has inputted
                    int number = 0;
                    if (int.TryParse(input, out number))
                    {
                        if (number >= 1 && number <= 1)
                        {
                            Console.WriteLine("Ascending or Descending order? Press A for Ascending and D for Descending.");
                            A_or_D = Console.ReadLine();

                            if (A_or_D == "A" || A_or_D == "a")
                            {
                                string[] readtext = File.ReadAllLines(R1_256FilePath);
                                int[] readText = readtext.Select(int.Parse).ToArray();
                                BubbleSort_Ascending(readText);
                                foreach (int s in readText)
                                {
                                    Console.WriteLine(s);
                                }
                                Console.WriteLine(readText.Length);
                                Console.ReadLine();
                            }
                            if (A_or_D == "D" || A_or_D == "d")
                            {
                                string[] readtext = File.ReadAllLines(R1_256FilePath);
                                int[] readText = readtext.Select(int.Parse).ToArray();
                                BubbleSort_Descending(readText);
                                foreach (int s in readText)
                                {
                                    Console.WriteLine(s);
                                }
                                Console.WriteLine(readText.Length);
                                Console.ReadLine();
                            }
                        }
                        if (number >= 2 && number <= 2)
                        {
                            Console.WriteLine("Ascending or Descending order? Press A for Ascending and D for Descending.");
                            A_or_D = Console.ReadLine();

                            if (A_or_D == "A" || A_or_D == "a")
                            {
                                string[] readtext = File.ReadAllLines(R2_256FilePath);
                                int[] readText = readtext.Select(int.Parse).ToArray();
                                InsertionSort_Ascending(readText);
                                foreach (int s in readText)
                                {
                                    Console.WriteLine(s);
                                }
                                Console.WriteLine(readText.Length);
                                Console.ReadLine();
                            }
                            if (A_or_D == "D" || A_or_D == "d")
                            {
                                string[] readtext = File.ReadAllLines(R2_256FilePath);
                                int[] readText = readtext.Select(int.Parse).ToArray();
                                InsertionSort_Descending(readText);
                                foreach (int s in readText)
                                {
                                    Console.WriteLine(s);
                                }
                                Console.WriteLine(readText.Length);
                                Console.ReadLine();
                            }
                        }
                        if (number >= 3 && number <= 3)

                        Console.WriteLine("Ascending or Descending order? Press A for Ascending and D for Descending.");
                        A_or_D = Console.ReadLine();

                        if (A_or_D == "A" || A_or_D == "a")
                        {
                            string[] readtext = File.ReadAllLines(R3_256FilePath);
                            int[] readText = readtext.Select(int.Parse).ToArray();
                            QuickSort_Ascending(readText, 0, readText.Length - 1);
                            foreach (int s in readText)
                            {
                                Console.WriteLine(s);
                            }
                            Console.WriteLine(readText.Length);
                            Console.ReadLine();
                        }
                        if (A_or_D == "D" || A_or_D == "d")
                        {
                            string[] readtext = File.ReadAllLines(R3_256FilePath);
                            int[] readText = readtext.Select(int.Parse).ToArray();
                            QuickSort_Descending(readText, 0, readText.Length - 1);
                            foreach (int s in readText)
                            {
                                Console.WriteLine(s);
                            }
                            Console.WriteLine(readText.Length);
                            Console.ReadLine();
                        }
                        if (number >= 4 && number <= 4)

                        Console.WriteLine("Ascending or Descending order? Press A for Ascending and D for Descending.");
                        A_or_D = Console.ReadLine();
                        if (A_or_D == "A" || A_or_D == "a")
                        {
                            string[] readtext = File.ReadAllLines(R1_2048FilePath);
                            int[] readText = readtext.Select(int.Parse).ToArray();
                            MergeSort_Ascending(readText, 0, readText.Length - 1);
                            foreach (int s in readText)
                            {
                                Console.WriteLine(s);
                            }
                            Console.WriteLine(readText.Length);
                            Console.ReadLine();
                        }
                        if (A_or_D == "D" || A_or_D == "d")
                        {
                            string[] readtext = File.ReadAllLines(R1_2048FilePath);
                            int[] readText = readtext.Select(int.Parse).ToArray();
                            MergeSort_Descending(readText, 0, readText.Length - 1);
                            foreach (int s in readText)
                            {
                                Console.WriteLine(s);
                            }
                            Console.WriteLine(readText.Length);
                            Console.ReadLine();
                        }
                        if (number >= 5 && number <= 5)
                        {
                            string[] readtext = File.ReadAllLines(R2_2048FilePath);
                            int[] readText = readtext.Select(int.Parse).ToArray();
                            //MergeSort(readText, 0, readText.Length - 1);
                            foreach (int s in readText)
                            {
                                Console.WriteLine(s);
                            }
                            Console.WriteLine(readText.Length);
                            Console.ReadLine();
                        }
                        if (number >= 6 && number <= 6)
                        {
                            string[] readtext = File.ReadAllLines(R3_2048FilePath);
                            int[] readText = readtext.Select(int.Parse).ToArray();
                            //MergeSort(readText, 0, readText.Length - 1);
                            foreach (int s in readText)
                            {
                                Console.WriteLine(s);
                            }
                            Console.WriteLine(readText.Length);
                            Console.ReadLine();
                        }
                        else
                        Console.WriteLine("Please choose a road set to view. Or quit the program.");
                    }
                }
            } while (!input.ToUpper().Equals("Q"));

        }
        private static void BubbleSort_Ascending(int[] arr)
        {
            int temporary;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temporary = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temporary;
                    }
                }
            }
        }
        private static void BubbleSort_Descending(int[] arr)
        {
            int temporary;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temporary = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temporary;
                    }
                }
            }
        }
        private static void InsertionSort_Ascending(int[] arr)
        {

            for (int x = 1; x < arr.Length; x++)
            {
                int val = arr[x];
                int flag = 0;
                for (int y = x - 1; y >= 0 && flag != 1;)
                {
                    if (val > arr[y])
                    {
                        flag = 1;
                    }
                    else
                    {
                        arr[y + 1] = arr[y];
                        y--;
                        arr[y + 1] = val;
                    }
                }

            }
        }
        private static void InsertionSort_Descending(int[] arr)
        {

            for (int x = 1; x < arr.Length; x++)
            {
                int val = arr[x];
                int flag = 0;
                for (int y = x - 1; y >= 0 && flag != 1;)
                {
                    if (val < arr[y])
                    {
                        flag = 1;
                    }
                    else
                    {
                        arr[y + 1] = arr[y];
                        y--;
                        arr[y + 1] = val;
                    }
                }

            }
        }


        private static void QuickSort_Ascending(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotPoint = Partition_Ascending(arr, left, right);

                if (pivotPoint > 1)
                {
                    QuickSort_Ascending(arr, left, pivotPoint - 1);
                }
                if (pivotPoint + 1 < right)
                {
                    QuickSort_Ascending(arr, pivotPoint + 1, right);
                }
            }
        }
        private static int Partition_Ascending(int[] arr, int left, int right)
        {
            int pivotPoint = arr[left];
            while (true)
            {
                while (arr[left] < pivotPoint)
                {
                    left++;
                }
                while (arr[right] > pivotPoint)
                {
                    right--;
                }
                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        private static void QuickSort_Descending(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotPoint = Partition_Descending(arr, left, right);

                if (pivotPoint > 1)
                {
                    QuickSort_Descending(arr, left, pivotPoint - 1);
                }
                if (pivotPoint + 1 < right)
                {
                    QuickSort_Descending(arr, pivotPoint + 1, right);
                }
            }
        }
        private static int Partition_Descending(int[] arr, int left, int right)
        {
            int pivotPoint = arr[left];
            while (true)
            {
                while (arr[left] > pivotPoint)
                {
                    left++;
                }
                while (arr[right] < pivotPoint)
                {
                    right--;
                }
                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        private static void MergeSort_Ascending(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort_Ascending(input, left, middle);
                MergeSort_Ascending(input, middle + 1, right);

                Merge_Ascending(input, left, middle, right);
            }
        }
        public static void Merge_Ascending(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }
        private static void MergeSort_Descending(int[] input, int left, int right)
        {
            if (left > right)
            {
                int middle = (left + right) / 2;

                MergeSort_Descending(input, left, middle);
                MergeSort_Descending(input, middle + 1, right);

                Merge_Descending(input, left, middle, right);
            }
        }
        public static void Merge_Descending(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k > right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }
    }
}
