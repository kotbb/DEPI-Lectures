using System;

namespace Day4
{
    class Program
    {
        static void Main()
        {
            // ****************************** PART 01 ******************************

            #region Problem 1
            //try
            //{
            //    int[] arr1 = new int[3] { 1, 2, 3};
            //    foreach (var item in arr1)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    int[] arr2 = new int[] { 4, 5, 6 };
            //    foreach (var item in arr2)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    int[] arr3 = { 7, 8, 9 };
            //    foreach (var item in arr3)
            //    {
            //        Console.WriteLine(item);
            //    }

            //}
            //catch (IndexOutOfRangeException)
            //{

            //    throw;
            //}
            //// Question
            //// What is the default value assigned to array elements in C#?
            //// for numberic types the default value is 0, for bool is false, and for reference types is null.

            #endregion

            #region Problem 2
            //int[] arr1 = { 1, 2 }; 
            //int[] arr2 = { 3, 4 };
            //Console.WriteLine("Before Shallow Copy:");

            //Console.WriteLine($"Arr2 location in memory = {arr2.GetHashCode()}");
            //// shallow copy
            //arr2 = arr1;
            //arr2[0] = 5;
            //Console.WriteLine("After Shallow Copy:");
            //Console.WriteLine($"Arr1 location in memory = {arr1.GetHashCode()}");
            //Console.WriteLine($"Arr2 location in memory after shallow copy = {arr2.GetHashCode()}");
            //foreach (var item in arr2)
            //{
            //    Console.WriteLine(item); // 1, 2
            //}

            //arr2 = (int[])arr1.Clone();
            //arr2[0] = 10;
            //Console.WriteLine("After Deep Copy:");
            //Console.WriteLine($"Arr2 location in memory = {arr2.GetHashCode()}");
            //foreach (var item in arr2)
            //{
            //    Console.WriteLine(item); //  10, 2
            //}

            //// Question
            //// What is the difference between Array.Clone() and Array.Copy()?
            //// Array.Clone() creates and returns a new array containing a copy of all elements.
            //// Array.Copy() copies elements from one array to an existing array and does not return anything.

            #endregion

            #region Problem 3 
            //int[,] grades = new int[3, 3];
            //for (int i = 0; i < grades.GetLength(0); i++)
            //{
            //    for (int j = 0; j < grades.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter grade for Student {i + 1}, Subject {j + 1}: ");
            //        grades[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < grades.GetLength(0); i++)
            //{
            //    Console.Write($"Grades for Student {i + 1}: ");
            //    for (int j = 0; j < grades.GetLength(1); j++)
            //    {
            //        Console.Write($"{grades[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            //// Question
            //// What is the difference between GetLength() and Length for multidimensional arrays?
            //// GetLength(dimension, like no of rows or columns) returns the length of the specified dimension.
            //// Length returns the total number of elements in all dimensions.

            #endregion

            #region Problem 4
            //int[] arr = { 5, 2, 9, 1, 3 };

            //// Sort
            //Array.Sort(arr);
            //Console.WriteLine("After Sort:");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //// Reverse
            //Array.Reverse(arr);
            //Console.WriteLine("After Reverse:");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //// IndexOf

            //int index = Array.IndexOf(arr, 3);
            //Console.WriteLine($"Index: {index}");

            //// Copy

            //int[] arrCopy = new int[3];
            //Array.Copy(arr, arrCopy, 3);
            //Console.WriteLine("After Copy:");
            //foreach (var item in arrCopy)
            //{
            //    Console.WriteLine(item);
            //}

            //// Clear

            //Array.Clear(arr, 0, arr.Length);
            //Console.WriteLine("After Clear:");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //// Question
            //// What is the difference between Array.Copy() and Array.ConstrainedCopy() ?
            //// Array.Copy(): performs normal copy and if an error happens withing the process of copyying, the array will be partially copied.
            //// Array.ConstrainedCopy(): if an error happens it will cancel the whole process of copying, something like atomicity.
            #endregion

            #region Problem 5
            //int[] arr = { 1, 2, 3 };

            //// For loop
            //Console.WriteLine("For loop:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //// Foreach loop
            //Console.WriteLine("Foreach loop:");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //// While loop in reverse order
            //Console.WriteLine("While loop in reverse order:");
            //int j = arr.Length - 1;
            //while (j >= 0)
            //{
            //    Console.WriteLine(arr[j]);
            //    j--;

            //}
            //// Question
            //// Why is foreach preferred for read-only operations on arrays?
            //// it is more readable and simple, and automatic adust modification of elements.

            #endregion

            #region Problem 6
            //int num;
            //do
            //{
            //    Console.WriteLine("Enter a posistive odd number:");
            //    string input = Console.ReadLine();
            //    if (!int.TryParse(input, out num))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid integer.");
            //        continue;
            //    }
            //    if (num <= 0)
            //    {
            //        Console.WriteLine("Number must be positive.");
            //        continue;
            //    }

            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine("Number must be odd.");
            //        continue;
            //    }
            //    break;

            //} while (true);
            //Console.WriteLine($"You entered a valid positive odd number: {num}");

            //// Question
            //// Why is input validation important when working with user inputs?
            //// It prevents errors and exceptions, enhances security, improves user experience, and ensures data integrity.

            #endregion

            #region Problem 7 
            //int[,] arr2d = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            //for (int i = 0; i < arr2d.GetLength(0); i++) 
            //{
            //    for (int j = 0; j < arr2d.GetLength(1); j++) 
            //    {
            //        Console.Write(arr2d[i, j] + "  "); 
            //    }
            //    Console.WriteLine(); 
            //}

            //// Question
            //// How can you format the output of a 2D array for better readability?
            //// use nested loops and format the output with spaces between elements and new lines between rows.

            #endregion

            #region Problem 8
            //Console.Write("Enter a month number:");
            //string input = Console.ReadLine();
            //int.TryParse(input, out int month);
            //string monthName;

            //if(month == 1) monthName = "January";
            //else if(month == 2) monthName = "February";
            //else if(month == 3) monthName = "March";
            //else if(month == 4) monthName = "April";
            //else if(month == 5) monthName = "May";
            //else if(month == 6) monthName = "June";
            //else if(month == 7) monthName = "July";
            //else if(month == 8) monthName = "August";
            //else if(month == 9) monthName = "September";
            //else if(month == 10) monthName = "October";
            //else if(month == 11) monthName = "November";
            //else if(month == 12) monthName = "December";
            //else 
            //    monthName = "Invalid month number";

            //switch (month)
            //{
            //    case 1:
            //        monthName = "January";
            //        break;
            //    case 2:
            //        monthName = "February";
            //        break;
            //    case 3:
            //        monthName = "March";
            //        break;
            //    case 4:
            //        monthName = "April";
            //        break;
            //    case 5:
            //        monthName = "May";
            //        break;
            //    case 6:
            //        monthName = "June";
            //        break;
            //    case 7:
            //        monthName = "July";
            //        break;
            //    case 8:
            //        monthName = "August";
            //        break;
            //    case 9:
            //        monthName = "September";
            //        break;
            //    case 10:
            //        monthName = "October";
            //        break;
            //    case 11:
            //        monthName = "November";
            //        break;
            //    case 12:
            //        monthName = "December";
            //        break;
            //    default:
            //        monthName = "Invalid month number";
            //        break;
            //}

            //Console.WriteLine($"Month name: {monthName}");

            //// Question
            //// When should you prefer a switch statement over if-else?
            //// when the conditions will be over 5 or when checking a single variable against multiple constant values.

            #endregion

            #region Problem 9
            //int[] arr = {5, 2, 9, 1, 5, 6};
            //Console.WriteLine("Original array:");

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //// Sort
            //Array.Sort(arr);
            //Console.WriteLine("Sorted array:");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //int firstIndex = Array.IndexOf(arr, 5);
            //int lastIndex = Array.LastIndexOf(arr, 5);
            //Console.WriteLine($"First Index of 5: {firstIndex}");
            //Console.WriteLine($"Last Index of 5: {lastIndex}");

            //// Question
            //// What is the time complexity of Array.Sort()?
            //// O(n log n)

            #endregion

            #region Problem 10
            //int[] arr = { 5, 2, 9, 1, 5, 6 };
            //int sum1 = 0;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    sum1 += arr[i];
            //}
            //Console.WriteLine($"Sum using for loop: {sum1}");

            //int sum2 = 0;
            //for (int j = 0; j < arr.Length; j++)
            //{
            //    sum2 += arr[j];
            //}
            //Console.WriteLine($"Sum using for loop: {sum2}");

            //// Question
            //// Which loop (for or foreach) is more efficient for calculating the sum of an array, and why?
            //// for loop is slightly more efficient for arrays.
            //// Reason: it directly accesses elements by index, avoiding the enumerator overhead that foreach uses.

            #endregion

            // ****************************** PART 02 ******************************
            //Console.Write("Enter a number of a day:");
            //string input = Console.ReadLine();
            //bool check = int.TryParse(input, out int dayNumber);
            //if(!check)
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //    return;
            //}
            //DayOfWeek day = Enum.Parse<DayOfWeek>(input);
            //Console.WriteLine($"Day: {day}");

            //// Question
            //// 3- What happens if the user enters a value outside the range of 1 to 7?
            //// it will return the same value as an interger but will not return the valid day of the integer


        }
    }
   
    enum DayOfWeek
    {
        Saturday = 1,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
}
