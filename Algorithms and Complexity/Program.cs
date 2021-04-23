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
            //the file paths for the txt files are declared below and saved as a string
            string R1_256FilePath = @"Road_1_256.txt";
            string R2_256FilePath = @"Road_2_256.txt";
            string R3_256FilePath = @"Road_3_256.txt";
            string R1_2048FilePath = @"Road_1_2048.txt";
            string R2_2048FilePath = @"Road_2_2048.txt";
            string R3_2048FilePath = @"Road_3_2048.txt";

            //the first input is declared as empty until the user decides
            string input = "";
            //as is the second input, this allows the user to decide whether they want the sorting algorithms to ascend or descend in order
            string A_or_D = "";

            
            //the program then enters a do-while loop
            do
            {
                //asks the user to choose a data set to read
                Console.WriteLine("Please choose a road data set to view, the options are 1, 2, 3, 4, 5, 6, 7 and 8. Or quit the program. ");
                //how input is read into the console
                input = Console.ReadLine();
                if (!input.ToUpper().Equals("Q"))
                {
                    //number is automatically set to 0, if the user enters a number between 1-7 then it's value is temporarily changed to allow the user to view the data set
                    int number = 0;
                    if (int.TryParse(input, out number))
                    {
                        //                                                        NUMBER 1 IS SELECTED                                                          
                        //checks if the user inputs the number 1 to select the data set
                        if (number >= 1 && number <= 1)
                        {
                            //asks the user if they woulld like the data set in ascending or descending order
                            Console.WriteLine("Ascending or Descending order? Press A for Ascending and D for Descending.");
                            //the console then reads what option the user has chosen to read the data set
                            A_or_D = Console.ReadLine();

                            //Ascending code
                            if (A_or_D == "A" || A_or_D == "a")
                            {
                                string[] readtext = File.ReadAllLines(R1_256FilePath); //grabs the txt file path and turns it into a string array
                                int[] readText = readtext.Select(int.Parse).ToArray(); //the string array is then turned into an integer array
                                Ascending_BubbleSort(readText); //bubblesort ascending is then called to print out the array in an ascending order
                                TenPrinting(readText); //called to print out every 10th value within the array
                                Console.WriteLine(readText.Length); //writes out how many values are contained in the array
                                Ascending_BinarySearch(readText); //Ascending binary search is then called which allows the user to search for a specific value within the array, if it can't find that specific value then the nearest one is given
                            }
                            //Descending code
                            if (A_or_D == "D" || A_or_D == "d")
                            {
                                string[] readtext = File.ReadAllLines(R1_256FilePath); //grabs the txt file path and turns it into a string array
                                int[] readText = readtext.Select(int.Parse).ToArray(); //the string array is then turned into an integer array
                                Descending_BubbleSort(readText); //bubblesort descending is then called to print out the array in an descending order
                                TenPrinting(readText); //called to print out every 10th value within the array
                                Console.WriteLine(readText.Length); //writes out how many values are contained in the array
                                Descending_BinarySearch(readText); //Descending binary search is then called which allows the user to search for a specific value within the array, if it can't find that specific value then the nearest one is given
                            }
                        }
                        //checks if the user inputs the number 2 to select the data set

                        //                                                        NUMBER 2 IS SELECTED                                                          
                        if (number >= 2 && number <= 2)
                        {
                            //asks the user if they woulld like the data set in ascending or descending order
                            Console.WriteLine("Ascending or Descending order? Press A for Ascending and D for Descending.");
                            //the console then reads what option the user has chosen to read the data set
                            A_or_D = Console.ReadLine();
                            //Ascending code
                            if (A_or_D == "A" || A_or_D == "a")
                            {
                                string[] readtext = File.ReadAllLines(R2_256FilePath); //grabs the txt file path and turns it into a string array
                                int[] readText = readtext.Select(int.Parse).ToArray(); //the string array is then turned into an integer array
                                Ascending_InsertionSort(readText); //insertionsort ascending is then called to print out the array in an ascending order
                                TenPrinting(readText); //called to print out every 10th value within the array
                                Console.WriteLine(readText.Length); //writes out how many values are contained in the array
                                IntegerArray_LinearSearch(readText); //Linear search is then called which allows the user to search for a specific value within the array, if it can't find that specific value then the nearest one is given
                            }
                            //Descending code
                            if (A_or_D == "D" || A_or_D == "d")
                            {
                                string[] readtext = File.ReadAllLines(R2_256FilePath); //grabs the txt file path and turns it into a string array
                                int[] readText = readtext.Select(int.Parse).ToArray(); //the string array is then turned into an integer array
                                Descending_InsertionSort(readText); //insertionsort ascending is then called to print out the array in an ascending order
                                TenPrinting(readText); //called to print out every 10th value within the array
                                Console.WriteLine(readText.Length); //writes out how many values are contained in the array
                                IntegerArray_LinearSearch(readText); //Linear search is then called which allows the user to search for a specific value within the array, if it can't find that specific value then the nearest one is given
                            }
                        }
                        //                                                        NUMBER 3 IS SELECTED                                                          
                        if (number >= 3 && number <= 3)
                        {
                            Console.WriteLine("Ascending or Descending order? Press A for Ascending and D for Descending.");
                            A_or_D = Console.ReadLine();

                            if (A_or_D == "A" || A_or_D == "a")
                            {
                                string[] readtext = File.ReadAllLines(R3_256FilePath); //grabs the txt file path and turns it into a string array
                                int[] readText = readtext.Select(int.Parse).ToArray(); //the string array is then turned into an integer array
                                int step = AscendingQuickSort(readText, 0, readText.Length - 1, 0); //values such as the array, left, right and step values are read into the ascending quicksort algorithm
                                Console.WriteLine($"This algorithm has run {step} times"); //count is set to 0 when is first called, and increase by 1 everytime it is used
                                TenPrinting(readText); //called to print out every 10th value within the array
                                Console.WriteLine(readText.Length); //writes out how many values are contained in the array
                                Ascending_BinarySearch(readText); //Ascending binary search is then called which allows the user to search for a specific value within the array, if it can't find that specific value then the nearest one is given
                            }
                            if (A_or_D == "D" || A_or_D == "d")
                            {
                                string[] readtext = File.ReadAllLines(R3_256FilePath); //grabs the txt file path and turns it into a string array
                                int[] readText = readtext.Select(int.Parse).ToArray(); //the string array is then turned into an integer array
                                int step = Descending_QuickSort(readText, 0, readText.Length - 1, 0); //values such as the array, left, right and step values are read into the descending quicksort algorithm
                                Console.WriteLine($"This algorithm has run {step} times"); //count is set to 0 when is first called, and increase by 1 everytime it is used
                                TenPrinting(readText); //called to print out every 10th value within the array
                                Console.WriteLine(readText.Length); //writes out how many values are contained in the array
                                Descending_BinarySearch(readText); //Descending binary search is then called which allows the user to search for a specific value within the array, if it can't find that specific value then the nearest one is given
                            }
                        }
                        //                                                        NUMBER 4 IS SELECTED                                                          
                        if (number >= 4 && number <= 4)
                        {
                            Console.WriteLine("Ascending or Descending order? Press A for Ascending and D for Descending.");
                            A_or_D = Console.ReadLine();
                            if (A_or_D == "A" || A_or_D == "a")
                            {
                                string[] readtext = File.ReadAllLines(R1_2048FilePath); //grabs the txt file path and turns it into a string array
                                int[] readText = readtext.Select(int.Parse).ToArray(); //the string array is then turned into an integer array
                                //Ascending_BubbleSort(readText);
                                int count = Ascending_MergeSort(readText, 0, readText.Length - 1, 0); //values such as the array, left, right and counting values are read into the ascending mergesort algorithm
                                Console.WriteLine($"This algorithm has run {count} times"); //count is set to 0 when is first called, and increase by 1 everytime it is used
                                FiftyPrinting(readText); //called to print out every 50th value within the array
                                Console.WriteLine(readText.Length); //writes out how many values are contained in the array
                                IntegerArray_LinearSearch(readText); //Linear search is then called which allows the user to search for a specific value within the array, if it can't find that specific value then the nearest one is given
                            }
                            if (A_or_D == "D" || A_or_D == "d")
                            {
                                string[] readtext = File.ReadAllLines(R1_2048FilePath); //grabs the txt file path and turns it into a string array
                                int[] readText = readtext.Select(int.Parse).ToArray(); //the string array is then turned into an integer array
                                int count = Descending_MergeSort(readText, 0, readText.Length - 1, 0); //values such as the array, left, right and counting values are read into the descending mergesort algorithm
                                Console.WriteLine($"This algorithm has run {count} times"); //count is set to 0 when is first called, and increase by 1 everytime it is used
                                FiftyPrinting(readText); //called to print out every 50th value within the array
                                Console.WriteLine(readText.Length); //writes out how many values are contained in the array
                                IntegerArray_LinearSearch(readText); //Linear search is then called which allows the user to search for a specific value within the array, if it can't find that specific value then the nearest one is given
                            }
                        }
                        //                                                        NUMBER 5 IS SELECTED                                                          
                        if (number >= 5 && number <= 5)
                        {
                            Console.WriteLine("Ascending or Descending order? Press A for Ascending and D for Descending.");
                            A_or_D = Console.ReadLine();
                            if (A_or_D == "A" || A_or_D == "a")
                             {
                                 string[] readtext = File.ReadAllLines(R2_2048FilePath); //grabs the txt file path and turns it into a string array
                                 int[] readText = readtext.Select(int.Parse).ToArray(); //the string array is then turned into an integer array
                                 int count = Descending_MergeSort(readText, 0, readText.Length - 1, 0); //ascending bubblesort is called and sorts the array into an ascending order before printing
                                 Console.WriteLine($"This algorithm has run {count} times"); //count is set to 0 when is first called, and increase by 1 everytime it is used
                                 FiftyPrinting(readText); //called to print out every 50th value within the array
                                 Console.WriteLine(readText.Length); //writes out how many values are contained in the array
                                 Ascending_BinarySearch(readText); //Ascending binary search is then called which allows the user to search for a specific value within the array, if it can't find that specific value then the nearest one is given
                            }
                        
                            if (A_or_D == "D" || A_or_D == "d")
                            {
                                string[] readtext = File.ReadAllLines(R2_2048FilePath); //grabs the txt file path and turns it into a string array
                                int[] readText = readtext.Select(int.Parse).ToArray(); //the string array is then turned into an integer array
                                int count = Descending_MergeSort(readText, 0, readText.Length - 1, 0); //ascending bubblesort is called and sorts the array into an ascending order before printing
                                Console.WriteLine($"This algorithm has run {count} times"); //count is set to 0 when is first called, and increase by 1 everytime it is used
                                FiftyPrinting(readText); //called to print out every 50th value within the array
                                Console.WriteLine(readText.Length); //writes out how many values are contained in the array
                                Descending_BinarySearch(readText); //Descending binary search is then called which allows the user to search for a specific value within the array, if it can't find that specific value then the nearest one is given
                            }
                        }
                        //                                                        NUMBER 6 IS SELECTED                                                          
                        if (number >= 6 && number <= 6)
                        {
                            Console.WriteLine("Ascending or Descending order? Press A for Ascending and D for Descending.");
                            A_or_D = Console.ReadLine();
                            if (A_or_D == "A" || A_or_D == "a")
                            {
                                string[] readtext = File.ReadAllLines(R3_2048FilePath); //grabs the txt file path and turns it into a string array
                                int[] readText = readtext.Select(int.Parse).ToArray(); //the string array is then turned into an integer array
                                int count = Descending_MergeSort(readText, 0, readText.Length - 1, 0); //ascending bubblesort is called and sorts the array into an ascending order before printing
                                Console.WriteLine($"This algorithm has run {count} times"); //count is set to 0 when is first called, and increase by 1 everytime it is used
                                FiftyPrinting(readText); //called to print out every 50th value within the array
                                Console.WriteLine(readText.Length); //writes out how many values are contained in the array
                                IntegerArray_LinearSearch(readText); //Linear search is then called which allows the user to search for a specific value within the array, if it can't find that specific value then the nearest one is given
                            }
                            if (A_or_D == "D" || A_or_D == "d")
                            {
                                string[] readtext = File.ReadAllLines(R3_2048FilePath); //grabs the txt file path and turns it into a string array
                                int[] readText = readtext.Select(int.Parse).ToArray(); //the string array is then turned into an integer array
                                int count = Descending_MergeSort(readText, 0, readText.Length - 1, 0); //ascending bubblesort is called and sorts the array into an ascending order before printing
                                Console.WriteLine($"This algorithm has run {count} times"); //count is set to 0 when is first called, and increase by 1 everytime it is used
                                FiftyPrinting(readText); //called to print out every 50th value within the array
                                Console.WriteLine(readText.Length); //writes out how many values are contained in the array
                                IntegerArray_LinearSearch(readText); //Linear search is then called which allows the user to search for a specific value within the array, if it can't find that specific value then the nearest one is given
                            }
                        }
                        //                                                        NUMBER 7 IS SELECTED                                                          
                        if (number >= 7 && number <= 7)
                        {
                            string[] file1 = File.ReadAllLines(R1_256FilePath); //grabs the txt file path and turns it into a string array
                            string[] file2 = File.ReadAllLines(R3_256FilePath); //grabs the txt file path and turns it into a string array
                            string[] readtext = new string[file1.Length * 2]; //doubles the length of the string file1 array
                            foreach(int i in Enumerable.Range(0, file1.Length))
                            {
                                readtext[i] = file1[i];
                                readtext[i + file1.Length] = file2[i];

                            }
                            int[] readText = readtext.Select(int.Parse).ToArray(); //readtext is converted into an integer array
                            Descending_BubbleSort(readText);
                            FiftyPrinting(readText); //called to print out every 50th value within the array
                            Descending_BinarySearch(readText); //descending bubblesort is called and sorts the array into an ascending order before printing
                        }
                        if (number >= 8 && number <= 8)
                        {
                            string[] file1 = File.ReadAllLines(R1_2048FilePath); //grabs the txt file path and turns it into a string array
                            string[] file2 = File.ReadAllLines(R3_2048FilePath); //grabs the txt file path and turns it into a string array
                            string[] readtext = new string[file1.Length * 2]; //doubles the length of the string file1 array
                            foreach (int i in Enumerable.Range(0, file1.Length))
                            {
                                readtext[i] = file1[i];
                                readtext[i + file1.Length] = file2[i];

                            }
                            int[] readText = readtext.Select(int.Parse).ToArray(); //readtext is converted into an integer array
                            Descending_BubbleSort(readText);
                            FiftyPrinting(readText); //called to print out every 50th value within the array
                            Descending_BinarySearch(readText);
                        }
                    }
                }
            } while (!input.ToUpper().Equals("Q"));

        }
        //here is the code for printing the 10th Value within an array
        public static void TenPrinting(int[] arr)
        {
            foreach(int i in Enumerable.Range(0,  arr.Length - 1))
            {
                if ((i + 1) % 10 == 0) //saying if i+1 remainder 10 is equal to 0 then write the array which every 10th value it is applied to
                {
                    Console.WriteLine(arr[i]); //writes the array
                }
            }
        }
        //here is the code for printing the 50th Value within an array
        public static void FiftyPrinting(int[] arr)
        {
            foreach (int i in Enumerable.Range(0, arr.Length - 1))
            {
                if ((i + 1) % 50 == 0) //saying if i+1 remainder 50 is equal to 0 then write the array which every 50th value it is applied to
                {
                    Console.WriteLine(arr[i]); //writes the array
                }
            }
        }
        
        //here is the ascending bubblesort code
        private static void Ascending_BubbleSort(int[] arr)
        {
            int temporary; //value for a temporary array
            int count = 0; //counter is set to 0 when the algorithm is called
            for (int i = 0; i < arr.Length - 1; i++) //i is set to 0, if the length of the array is greater than i then it adds 1 to the value of i
            {
                for (int j = 0; j < arr.Length - 1 - i; j++) //j is set to 0, if the length of the array is greater than j then it adds 1 to the value of j
                {
                    if (arr[j] > arr[j + 1]) //if array [j] is greater than array[j + 1] then...
                    {
                        temporary = arr[j]; //temporary array value becomes array [j]
                        arr[j] = arr[j + 1]; // array [j] becomes array [j + 1]
                        arr[j + 1] = temporary; // array [j] + 1 then becomes the temporary array
                    }
                    count += 1; //a value is added to the counter every time the algorithm is run
                }
            }
            Console.WriteLine($"This algorithm has run {count} times"); //prints out the count value once the algorithm has ended
        }
        //here is the descending bubblesort code
        private static void Descending_BubbleSort(int[] arr)
        {
            int temporary; //value for a temporary array
            int count = 0; //counter is set to 0 when the algorithm is called
            for (int i = 0; i < arr.Length - 1; i++) //i is set to 0, if the length of the array is greater than i then it adds 1 to the value of i
            {
                for (int j = 0; j < arr.Length - 1 - i; j++) //j is set to 0, if the length of the array is greater than j then it adds 1 to the value of j
                {
                    if (arr[j] < arr[j + 1]) //if array [j] is greater than array [j] + 1 then...
                    {
                        temporary = arr[j]; //temporary array value becomes array == j
                        arr[j] = arr[j + 1]; // array == j becomes array == j + 1
                        arr[j + 1] = temporary; // array == j + 1 then becomes the temporary array
                    }
                    count += 1; //a value is added to the counter every time the algorithm is run
                }
            }
            Console.WriteLine($"This algorithm has run {count} times"); //prints out the count value once the algorithm has ended
        }
        //here is the code for the ascending insertion sort
        private static void Ascending_InsertionSort(int[] arr)
        {
            int count = 0; //counter is set to 0 when the algorithm is called
            for (int x = 1; x < arr.Length; x++) //x is set to a value of 1, if array length is greater than x, a value of 1 is added to x
            {
                int val = arr[x]; //value is equal to array[x]
                int flag = 0; //flag is the number others get compared to
                for (int y = x - 1; y >= 0 && flag != 1;) //y is set to x - 1, y is greater than or equal to 0 and flag 
                {
                    if (val > arr[y]) //if value is greater than array then...
                    {
                        flag = 1;
                    }
                    else
                    {
                        arr[y + 1] = arr[y]; //arr[y + 1] is then set to arr[y]
                        y--; //a value that is equal to 1 is then taken from y each time the algorithm is run
                        arr[y + 1] = val; //arr[y + 1] is then set to value
                    }
                    count += 1; //a value is added to the counter every time the algorithm is run
                }
            }
            Console.WriteLine($"This algorithm has run {count} times"); //prints out the count value once the algorithm has ended
        }
        //here is the descending insertion sort code
        private static void Descending_InsertionSort(int[] arr)
        {
            int count = 0; //counter is set to 0 when the algorithm is called
            for (int x = 1; x < arr.Length; x++) //x is set to a value of 1, if array length is greater than x, a value of 1 is added to x
            {
                int val = arr[x]; //value is equal to array[x]
                int flag = 0; //flag is the number others get compared to
                for (int y = x - 1; y >= 0 && flag != 1;) //y is set to x - 1, y is greater than or equal to 0 and flag 
                {
                    if (val < arr[y]) //if value is greater than array then...
                    {
                        flag = 1;
                    }
                    else
                    {
                        arr[y + 1] = arr[y]; //arr[y + 1] is then set to arr[y]
                        y--; //a value that is equal to 1 is then taken from y each time the algorithm is run
                        arr[y + 1] = val; //arr[y + 1] is then set to value
                    }
                    count += 1; //a value is added to the counter every time the algorithm is run
                }

            }
            Console.WriteLine($"This algorithm has run {count} times"); //prints out the count value once the algorithm has ended
        }
        //here is the code for the ascending quicksort
        private static int AscendingQuickSort(int[] arr, int left, int right, int step)
        {
            int i, j; //declares the int values
            int pivot, temp; //declares the pivot and temporary arrays
            i = left; //i is set to left
            j = right; //j is set to right
            pivot = arr[(left + right) / 2]; //pivot is then set to an array that is equal to left and right / 2
            do //do while is then initiallised
            {
                while ((arr[i] < pivot) && (i < right)) i++; //while arr[i] is less than pivot and i is less than right, i gains a value of 1
                while ((pivot < arr[j]) && (j > left)) j--; //while pivot is less than arr[j] and j is greater than left, j loses a value of 1
                if (i <= j) //if i is less than or equal to j
                {
                    temp = arr[i]; //temporary array becomes arr[i]
                    arr[i] = arr[j]; //arr[i] become arr[j]
                    arr[j] = temp; //arr[j] becomes temporary array
                    i++; //i gains a value of 1
                    j--; //j loses a value of 1
                    step++; //step gains a value of 1
                }
            } while (i <= j); //do while loop only works as long as i is less than or equal to j 
            if (left < j) step += AscendingQuickSort(arr, left, j, step);
            if (i < right) step += AscendingQuickSort(arr, i, right, step);
            return step;
        }
        //here is the descending quicksort code
        private static int Descending_QuickSort(int[] arr, int left, int right, int step)
        {

            int i, j; //declares the int values
            int pivot, temp; //declares the pivot and temporary arrays
            i = left; //i is set to left
            j = right; //j is set to right
            pivot = arr[(left + right) / 2]; //pivot is then set to an array that is equal to left and right / 2
            do //do while is then initiallised
            {
                while ((arr[i] > pivot) && (i < right)) i++; //while arr[i] is less than pivot and i is less than right, i gains a value of 1
                while ((pivot > arr[j]) && (j > left)) j--; //while pivot is less than arr[j] and j is greater than left, j loses a value of 1
                if (i <= j) //if i is less than or equal to j
                {
                    temp = arr[i]; //temporary array becomes arr[i]
                    arr[i] = arr[j]; //arr[i] become arr[j]
                    arr[j] = temp; //arr[j] becomes temporary array
                    i++; //i gains a value of 1
                    j--; //j loses a value of 1
                    step++; //step gains a value of 1
                }
            } while (i <= j); //do while loop only works as long as i is less than or equal to j 
            if (left < j) step += Descending_QuickSort(arr, left, j, step);
            if (i < right) step += Descending_QuickSort(arr, i, right, step);
            return step;
        }
        //here is the code for the ascending mergesort
        private static int Ascending_MergeSort(int[] input, int left, int right, int count)
        {
            if (left < right) //left is less than right
            {
                int middle = (left + right) / 2; //middle is equal to left and right / 2

                count = Ascending_MergeSort(input, left, middle, count);
                count = Ascending_MergeSort(input, middle + 1, right, count);

                count = Ascending_Merge(input, left, middle, right, count);
            }
            return count; //returns the count
        }
        private static int Ascending_Merge(int[] input, int left, int middle, int right, int count)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1); //copies the elements from the array
            Array.Copy(input, middle + 1, rightArray, 0, right - middle); //copies the elements from the array
            //ints are both set to 0
            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++) //k = left, k is less than right + 1, value of 1 added to k
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
                count += 1; //a value is added to the counter every time the algorithm is run
            }
            return count; //prints out the count value once the algorithm has ended
        }
        private static int Descending_MergeSort(int[] input, int left, int right, int count)
        {
            if (left < right) //left is less than right
            {
                int middle = (left + right) / 2; //middle is equal to left and right / 2

                count = Descending_MergeSort(input, left, middle, count);
                count = Descending_MergeSort(input, middle + 1, right, count);

                count = Descending_Merge(input, left, middle, right, count);
            }
            return count; //prints out the count value once the algorithm has ended
        }
        private static int Descending_Merge(int[] input, int left, int middle, int right, int count)
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
                else if (leftArray[i] >= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
                count += 1;
            }
            return count; //prints out the count value once the algorithm has ended
        }
        //here is the code for the linear search
        public static void IntegerArray_LinearSearch(int[] arr)
        {
            Console.WriteLine("Enter what number you are looking for: "); //asks the user what number they want to find
            string input = Console.ReadLine(); //reads user input into the console
            int number = Int32.Parse(input); //converts the number into a 32 bit signed integer by using parse
            int checkNumber = number; //check number is assigned as number
            List<int> places = new List<int>(); //places is declared as list
            bool done = false; //done is set as false to begin with
            //count and counter are set to 0
            int counter = 0;
            int count = 0;
            int val = 0;
            while(done == false) //while done is equivalent to false, a foreach loop is used
            {
                foreach (int i in Enumerable.Range(0, arr.Length - 1))
                {
                    if (arr[i] == checkNumber)
                    {
                        places.Add(i);
                    }
                    count += 1;
                }
                if (places.Count > 0)
                {
                    if (val > 0)
                    {
                        Console.WriteLine("Number not found");
                        Console.WriteLine($"The closest number in {checkNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"Number {input} was found");
                    }
                    places.ForEach(Console.WriteLine);
                    done = true;
                }
                else
                {
                    counter += 1;
                    if (counter % 2 == 1)
                    {
                        checkNumber = number + (counter / 2) + 1;
                    }
                    else
                    {
                        checkNumber = number - (counter / 2);
                    }
                }
                val += 1;
            }
            Console.WriteLine($"This algorithm has run {count} times"); //prints out the count value once the algorithm has ended
        }
        //here is the code for ascending binary search
        public static void Ascending_BinarySearch(int[] arr)
        {
            Console.WriteLine("Enter what number you are looking for: "); //asks the user what number they want
            string input = Console.ReadLine(); //reads the input
            int number = Int32.Parse(input); //converts to 32 bit int
            int key = number; //key is now equal to number
            bool finished = false; //finished is false
            bool done = false; //done is false
            //count and counter are 0
            int counter = 0;
            int count = 0;
            int val = 0;
            while (done == false) //while done is false...
            {
                int minNum = 0; //minimum number is 0
                int maxNum = arr.Length - 1; //max number is the length of the array - 1

                while (minNum <= maxNum && finished == false)
                {
                    int mid = (minNum + maxNum) / 2; //this finds the middle number (number in between minumum and maximum)
                    if (key == arr[mid])
                    {
                        if(val == 0)
                        {
                            Console.WriteLine($"Number found at position {mid + 1}");
                        }
                        else
                        {
                            Console.WriteLine($"Number cannot found");
                            Console.WriteLine($"The closest number is {arr[mid + 1]}");
                        }
                         
                        finished = true; 
                        done = true; 
                    }
                    else if (key < arr[mid])
                    {
                        maxNum = mid - 1;
                    }
                    else
                    {
                        minNum = mid + 1;
                    }
                    count += 1;
                }
                finished = false;
                if (minNum > maxNum)
                {
                    counter += 1;
                    if (counter % 2 == 1)
                    {
                        key = number + (counter / 2) + 1;
                    }
                    else
                    {
                        key = number - (counter / 2);
                    }
                }
                val += 1;
            }
            Console.WriteLine($"This algorithm has run {count} times"); //prints out the count value once the algorithm has ended

        }
        public static void Descending_BinarySearch(int[] arr) 
        {
            Console.WriteLine("Enter what number you are looking for"); //asks the user what number they want
            string input = Console.ReadLine(); //reads the input
            int number = Int32.Parse(input); //converts to 32 bit int
            int key = number; //key is now equal to number
            bool finished = false; //finished is false
            bool done = false; //done is false
            //count and counter are 0
            int counter = 0;
            int count = 0;
            int val = 0;
            while (done == false) //while done is false...
            {
                int minNum = 0; //minimum number is 0
                int maxNum = arr.Length - 1; //max number is the length of the array - 1

                while (minNum <= maxNum && finished == false)
                {
                    int mid = (minNum + maxNum) / 2; //this finds the middle number (number in between minumum and maximum)
                    if (key == arr[mid])
                    {
                        if (val == 0)
                        {
                            Console.WriteLine($"Number found at position {mid + 1}");
                        }
                        else
                        {
                            Console.WriteLine($"Number not found"); //shows that the number has not been found
                            Console.WriteLine($"The closest number is {arr[mid + 1]}"); //shows the closest number
                        }
                    {
                        Console.WriteLine($"Number found {key}"); //shows that the number has been found in the array
                        Console.WriteLine($"at position {mid + 1}"); //shows where in the array the number is held
                        finished = true; //finished is then finally true
                        done = true; //done is also true, algorithm ends
                        }
                        finished = true;
                        done = true;
                    }
                    else if (key > arr[mid])
                    {
                        maxNum = mid - 1;
                    }
                    else
                    {
                        minNum = mid + 1;
                    }
                    count += 1;
                }
                finished = false;
                if (minNum > maxNum)
                {
                    counter += 1;
                    if (counter % 2 == 1)
                    {
                        key = number + (counter / 2) + 1;
                    }
                    else
                    {
                        key = number - (counter / 2);
                    }
                }
                val += 1;
            }
            Console.WriteLine($"This algorithm has run {count} times"); //prints out the count value once the algorithm has ended
        }
    }
}