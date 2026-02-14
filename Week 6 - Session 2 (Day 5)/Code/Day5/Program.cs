using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Day5
{
    class Program
    {
        static void Main()
        {

            // *********************** PART 01 ************************

            #region Problem 1

            //try
            //{
            //    Console.Write("Enter first integer: ");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.Write("Enter second integer: ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    int res = num1 / num2;
            //    Console.WriteLine($"Result: {res}");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("You cannot divide by zero!");
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete");
            //}

            //// Question: What is the purpose of the finally block?
            //// The finally block is used to guarantee execution of code, whether an exception occurs or not.

            #endregion

            #region Problem 2

            //TestDefensiveCode();
            //// Question: How does int.TryParse() improve program robustness compared to int.Parse() ?
            //// int.TryParse: it safely handles invalid input without throwing exceptions.
            #endregion

            #region Problem 3
            //int? num = null;

            //int? result = num ?? 0;

            //if (num.HasValue)
            //{
            //    Console.WriteLine($"Value using HasValue: {num.Value}");
            //}
            //try
            //{
            //    Console.WriteLine(num.Value);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Exception: {ex}");
            //}

            //// HasValue: Checks if the nullable contains a value
            //// Value: it gets the actual value if it exists, otherwise it throws an exception

            //// Question: What exception occurs when trying to access Value on a null Nullable<T>?
            //// InvalidOperationException

            #endregion

            #region Problem 4

            //int[] arr = { 1, 2, 3, 4, 5 };

            //try
            //{
            //    int num = arr[6];
            //    Console.WriteLine(num);
            //}
            //catch (IndexOutOfRangeException)
            //{

            //    Console.WriteLine("You try to access invalid place in memory, (out of range of the array)");
            //}
            //// Question: Why is it necessary to check array bounds before accessing elements?
            //// to prevent runtime errors and ensure the program does not crash due to accessing invalid memory locations.

            #endregion

            #region Problem 5

            //int[,] arr = new int[3, 3];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter value at [{i},{j}]: ");
            //        arr[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    int rowsum = 0;
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        rowsum += arr[i, j];
            //    }
            //    Console.WriteLine($"Sum of Row {i}: {rowsum}");
            //}

            //for (int j = 0; j < arr.GetLength(0); j++)
            //{
            //    int colsum = 0;
            //    for (int i = 0; i < arr.GetLength(1); i++)
            //    {
            //        colsum += arr[i, j];
            //    }
            //    Console.WriteLine($"Sum of Column {j}: {colsum}");
            //}

            //// Question: How is the GetLength(dimension) method used in multi-dimensional arrays?

            //// gets the size of a specific dimension in a multi-dimensional array

            #endregion

            #region Problem 6

            //int[][] arr = new int[3][];
            //arr[0] = new int[2];
            //arr[1] = new int[3];
            //arr[2] = new int[4];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.WriteLine($"Enter value at [{i}][{j}]: ");
            //        arr[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("\nArray Values:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write(arr[i][j] + " ");

            //    }
            //    Console.WriteLine();
            //}

            //// Question: How does the memory allocation differ between jagged arrays and rectangular arrays ?
            //// Jagged arrays:
            //// Memory is allocated separately for each row
            //// Each inner array is an independent object on the heap
            //// Memory is non contiguous

            //// Rectungular arrays:
            //// Memory is allocated as one contiguous block
            //// All rows must have the same length

            #endregion

            #region Problem 7

            //string ? str = null;

            //Console.Write("Enter input:");

            //string? input = Console.ReadLine();

            //if (!string.IsNullOrEmpty(input))
            //{
            //    str = input;
            //}
            //Console.WriteLine($"{str?.Length}");

            //// Question: What is the purpose of nullable reference types in C#?
            //// Help detect null-reference bugs at compile time
            //// Reduce NullReferenceException at runtime

            #endregion

            #region Problem 8

            //// Boxing
            //int x = 10;
            //object obj = x;

            //// Unboxing
            //int y = (int)obj;

            //// Question: WWhat is the performance impact of boxing and unboxing in C#?
            //// Boxing & unboxing have a performance cost (heap allocation + copy)
            #endregion

            #region Problem 9
            //SumAndMultiply(5, 10, out int sum, out int product);
            //Console.WriteLine($"Sum = {sum} , Product = {product}");

            //// Question: Why must out parameters be initialized inside the method?
            //// The caller does not need to initialize an out variable
            //// So when control enters the method, the variable is considered unassigned
            //// To prevent undefined / garbage values, C# forces the method to assign it before returning

            #endregion

            #region Problem 10

            //Print("Hello");
            //Print("World", 10);

            //// Question: Why must optional parameters always appear at the end of a method's parameterlist ?
            //// When the compiler sees a method call, it matches arguments left to right.
            //// If optional parameters were allowed in the middle,
            //// the compiler wouldn’t know which parameter you’re skipping.
            #endregion

            #region Problem 11

            //int[]? arr = null;
            //int? len = arr?.Length;

            //Console.WriteLine($"Lenght of the array: {len}");

            //// Question: How does the null propagation operator prevent NullReferenceException?
            //// it checks if the object is null before accessing its members.
            //// If the object is null, it returns null instead of throwing an exception.

            #endregion

            #region Problem 12

            //Console.Write("Enter a day:");
            //string? day = Console.ReadLine();

            //int dayNumber = 0;

            //switch (day.ToLower())
            //{
            //    case "saturday":
            //        dayNumber = 1;
            //        break;

            //    case "sunday":
            //        dayNumber = 2;
            //        break;

            //    case "monday":
            //        dayNumber = 3;
            //        break;

            //    case "tuesday":
            //        dayNumber = 4;
            //        break;

            //    case "wednesday":
            //        dayNumber = 5;
            //        break;

            //    case "thursday":
            //        dayNumber = 6;
            //        break;

            //    case "friday":
            //        dayNumber = 7;
            //        break;

            //    default:
            //        break;
            //}
            //if (dayNumber == 0)
            //{
            //    Console.WriteLine("Invalid day!");
            //}
            //else {
            //    Console.WriteLine($"Day Number: {dayNumber}");
            //}

            //// Question: When is a switch expression preferred over a traditional if statement?
            //// when you have you are mapping one value to another and you have multiple cases related to the same output.
            //// when you don't have complex conditions and you want to improve readability 

            #endregion

            #region Problem 13

            //int[] arr = { 1, 2, 3, 4 };

            //Console.WriteLine($"Numbers individual: {SumArray(1, 2, 3, 4)}");

            //Console.WriteLine($"Array: {SumArray(arr)}");

            //// Question: What are the limitations of the params keyword in method definitions?

            //// Must be the last parameter like optional parameters
            //// Only one params parameter is allowed per method
            //// It is always an array
            //// Causes array allocation every call


            #endregion


            // *********************** PART 02 ************************

            #region Problem 1

            //Console.WriteLine("Enter a positive number:");
            //string? input = Console.ReadLine();
            //int.TryParse(input, out int value);
            //if (value < 1) {
            //    Console.WriteLine("The number should be positive !!");
            //    return;
            //}
            //for (int i = 1; i < value; i++)
            //{
            //    Console.Write($"{i}, ");
            //}
            //Console.Write($"{value}");

            #endregion

            #region Problem 2

            //Console.WriteLine("Enter a number:");
            //string? input = Console.ReadLine();
            //bool check = int.TryParse(input, out int value);

            //if (!check) {
            //    Console.WriteLine("Enter a valid number !!");
            //    return;
            //}
            //for (int i = 1; i < 12; i++)
            //{
            //    Console.Write($"{value * i}, ");
            //}
            //Console.Write($"{value * 12}");


            #endregion

            #region Problem 3

            //Console.WriteLine("Enter a number:");
            //string? input = Console.ReadLine();
            //bool check = int.TryParse(input, out int value);

            //if (!check)
            //{
            //    Console.WriteLine("Enter a valid number !!");
            //    return;
            //}
            //for (int i = 2; i < value; i += 2)
            //{
            //    Console.Write($"{i}, ");
            //}
            //if (value % 2 == 0)
            //{
            //    Console.Write($"{value}");
            //}

            #endregion

            #region Problem 4

            //Console.WriteLine("Enter base number");
            //string? input1 = Console.ReadLine();
            //int.TryParse(input1, out int baseN);

            //Console.WriteLine("Enter the power");
            //string? input2 = Console.ReadLine();
            //int.TryParse(input2, out int power);

            //int res = 1;
            //for (int i = 0; i < power; i++)
            //{
            //    res *= baseN;
            //}
            //Console.WriteLine($"Result: {res}");

            #endregion

            #region Problem 5

            //Console.WriteLine("Enter a message");
            //string? input = Console.ReadLine();
            //string reversed = "";
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversed += input[i];
            //}
            //Console.WriteLine($"the message after reverse: {reversed}");
            #endregion

            #region Problem 6

            //Console.WriteLine("Enter an integer");
            //string? input = Console.ReadLine();
            //string reversed = "";
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversed += input[i];
            //}
            //Console.WriteLine($"the integer after reverse: {reversed}");

            #endregion

            #region Problem 7



            #endregion

            #region Problem 8

            //Console.WriteLine("Enter a sentence:");
            //string? sentence = Console.ReadLine();

            //string[] arr = sentence.Split(' ');
            //string reversed = "";
            //foreach (var item in arr)
            //{
            //    reversed = item + " "  + reversed;
            //}
            //Console.WriteLine($"After reversing the sentence: {reversed}");
            #endregion

        }

        // *********************** PART 01 ************************
        #region Problem 2

        //public static void TestDefensiveCode()
        //{
        //    int X, Y, Z;

        //    do
        //    {
        //        Console.WriteLine("Enter first Number (positive): ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(), out X) || X <= 0);

        //    do
        //    {
        //        Console.WriteLine("Enter Second Number (greater than 1): ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);

        //    Z = X / Y;
        //    Console.WriteLine($"Result = {Z}");

        //    int[] arr = { 1, 2, 3 };
        //    if (arr?.Length > 69)
        //        arr[69] = 90;
        //}



        #endregion

        #region Problem 9
        //public static void SumAndMultiply(int a, int b, out int sum, out int product)
        //{
        //    sum = a + b;
        //    product = a * b;
        //}

        #endregion

        #region Problem 10

        //public static void Print(string s, int times = 5)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        Console.WriteLine(s);
        //    }
        //}

        #endregion

        #region Problem 13

        //public static int SumArray(params int[] numbers)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        sum += numbers[i];
        //    }
        //    return sum;
        //}

        #endregion


    }
}