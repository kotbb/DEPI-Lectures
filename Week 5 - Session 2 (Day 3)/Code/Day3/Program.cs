using System;
using System.Text;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Problem1
            //try
            //{
            //    Console.Write("Enter input: ");
            //    string input = Console.ReadLine();
            //    Console.WriteLine(input);
            //    int numConvert = Convert.ToInt32(input);
            //    int numParse = int.Parse(input);

            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            ///* Question 
            //  Parse: not accept null values, throw exception if null
            //  Convert: accept null values, return 0 if null 
            // */
            #endregion

            #region Problem2
            //Console.Write("Enter input: ");
            //string input = Console.ReadLine();
            //bool isSuccess = int.TryParse(input, out int x);
            //if(isSuccess)
            //{
            //    Console.WriteLine($"Conversion successful: {x}");
            //}
            //else
            //{
            //    Console.WriteLine("Conversion failed.");
            //}
            ///* Question 
            //  TryParse: not return execptions, return boolean while parse returns
            //  this make the performance more better because it will simple check if the boolean is true or false
            // */

            #endregion

            #region Problem3
            //object obj;
            //obj = 10;
            //Console.WriteLine(obj.GetHashCode());

            //obj = "Hello World";
            //Console.WriteLine(obj.GetHashCode());

            //obj = 10.5;
            //Console.WriteLine(obj.GetHashCode());

            ///* Question
            // GetHashCode return a unique hash code for each value that is assigneed to,
            // this hash code is used to identify the object in heap, so if I want to
            // compare if two objects are the same or not I can compare their hash codes.

            // */
            #endregion

            #region Problem4
            //object obj = "Mohamed";
            //object obj2 = obj;
            //obj = "Ahmed";
            //Console.WriteLine(obj2);
            //// here it will still Mohamed because when we assigned obj to Ahmed
            //// it creates a new object in the heap and reference to it, and
            //// the firest object is still existed and obj2 is still reference to it

            ///* Question
            //   reference equality compares if the the two objects point to the same memory location

            // */
            #endregion

            #region Problem5
            //string str = "Hi";
            //Console.WriteLine(str.GetHashCode());
            //str += " Willy";
            //Console.WriteLine(str.GetHashCode());

            ///* Question 
            // why string is immuatable beacuse it is represented in the heap
            // as array of characters and the array in the memory cannot be changed
            // */
            #endregion

            #region Problem6
            //StringBuilder str = new StringBuilder("Hi");
            //Console.WriteLine(str.GetHashCode());
            //str.Append(" Willy");
            //Console.WriteLine(str.GetHashCode());

            ///* Question
            //  stringbuilder is stored in heap as linkedlist of characters
            //  that means when we append a new string to the stringbuilder
            //  it simply points to it using the linkedlist without making
            //  a new object and append to it like string concatination
            //  so it is used in for large-scale modification to prevent
            //  creating many unreachable objects and waster resources
            //*/
            #endregion

            #region Problem7
            //Console.Write("Enter first integer: ");
            //int.TryParse(Console.ReadLine(), out int num1);
            //Console.Write("Enter second integer: ");
            //int.TryParse(Console.ReadLine(), out int num2);
            //Console.WriteLine("Sum is: " + (num1 + num2));
            //Console.WriteLine(string.Format("Sum is: {0}", num1 + num2));
            //Console.WriteLine($"Sum is: {num1 + num2}");

            ///* Question
            //  String interpolation ($) becuase first it not create new objects and wast 
            //  resources like concatination (+), second it is more readable than string.format
            // */
            #endregion

            #region Problem8
            //StringBuilder sb = new StringBuilder("Hello");

            //// Append
            //sb.Append(" World");  // Hello World
            //Console.WriteLine(sb);

            //// Replace
            //sb.Replace("World", "Mohamed");
            //Console.WriteLine(sb); // Hello Mohamed

            //// Insert
            //sb.Insert(13, " Ahmed");
            //Console.WriteLine(sb); // Hello Mohamed Ahmed

            //// Remove
            //sb.Remove(13, 6);
            //Console.WriteLine(sb); // Hello Mohamed

            //// Question
            //// The same answer like the question in Problem 6
            #endregion

        }
    }
}
