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
            string R1_256FilePath = @"C:\Users\Antony\Documents\C# Projects\Algorithms and Complexity - Antony Scott\bin\debug\Road_1_256.txt";
            string R2_256FilePath = @"C:\Users\Antony\Documents\C# Projects\Algorithms and Complexity - Antony Scott\bin\debug\Road_2_256.txt";
            string R3_256FilePath = @"C:\Users\Antony\Documents\C# Projects\Algorithms and Complexity - Antony Scott\bin\debug\Road_3_256.txt";
            string R1_2048FilePath = @"C:\Users\Antony\Documents\C# Projects\Algorithms and Complexity - Antony Scott\bin\debug\Road_1_2048.txt";
            string R2_2048FilePath = @"C:\Users\Antony\Documents\C# Projects\Algorithms and Complexity - Antony Scott\bin\debug\Road_2_2048.txt";
            string R3_2048FilePath = @"C:\Users\Antony\Documents\C# Projects\Algorithms and Complexity - Antony Scott\bin\debug\Road_3_2048.txt";

            string input = "";
            do
            {
                Console.WriteLine("Please choose a road data set to view, the options are 1, 2, 3, 4, 5 and 6. Or quit the program. ");
                input = Console.ReadLine();
                if (!input.ToUpper().Equals("Q"))
                {
                    int number = 0;
                    if (int.TryParse(input, out number))
                    {
                        if (number >= 1 && number <= 1)
                        {
                            string[] readtext = File.ReadAllLines(R1_256FilePath);
                            int[] readText = readtext.Select(int.Parse).ToArray();
                            BubbleSort(readText);
                            foreach (int s in readText)
                            {
                                Console.WriteLine(s);
                            }
                            Console.WriteLine(readText.Length);
                            Console.ReadLine();
                        }
                        if (number >= 2 && number <= 2)
                        {
                            string[] readtext = File.ReadAllLines(R2_256FilePath);
                            int[] readText = readtext.Select(int.Parse).ToArray();
                            InsertionsSort(readText);
                            foreach (int s in readText)
                            {
                                Console.WriteLine(s);
                            }
                            Console.WriteLine(readText.Length);
                            Console.ReadLine();
                        }
                        if (number >= 3 && number <= 3)
                        {
                            string[] readtext = File.ReadAllLines(R3_256FilePath);
                            int[] readText = readtext.Select(int.Parse).ToArray();
                            QuickSort(readText, 0, readText.Length - 1);
                            foreach (int s in readText)
                            {
                                Console.WriteLine(s);
                            }
                            Console.WriteLine(readText.Length);
                            Console.ReadLine();
                        }
                        if (number >= 4 && number <= 4)
                        {
                            string[] readtext = File.ReadAllLines(R1_2048FilePath);
                            int[] readText = readtext.Select(int.Parse).ToArray();
                            //printArray(readText);
                            MergeSort(readText, 0, readText.Length - 1);
                            //printArray(readText);
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
                            //printArray(readText);
                            MergeSort(readText, 0, readText.Length - 1);
                            //printArray(readText);
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
                            //printArray(readText);
                            MergeSort(readText, 0, readText.Length - 1);
                            //printArray(readText);
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
        private static void BubbleSort(int[] arr)
        {
            for (int p = 0; p <= arr.Length - 2; p++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int t = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = t;
                    }
                }
            }
        }
        private static void InsertionsSort(int[] arr)
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

        private static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotPoint = Partition(arr, left, right);

                if (pivotPoint > 1)
                {
                    QuickSort(arr, left, pivotPoint - 1);
                }
                if (pivotPoint + 1 < right)
                {
                    QuickSort(arr, pivotPoint + 1, right);
                }
            }
        }
        private static int Partition(int[] arr, int left, int right)
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

        public static void Merge(int[] input, int left, int middle, int right)
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

        public static void MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);

                Merge(input, left, middle, right);
            }
        }
        public static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.WriteLine(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
