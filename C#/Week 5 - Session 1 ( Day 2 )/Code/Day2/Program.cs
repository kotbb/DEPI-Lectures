using System;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ******** Part 1 ********

            #region Problem 1
            //// Declare two integer variables x,y and print their sum
            //int x = 10;
            //int y = 20;
            //int sum = x + y;
            //Console.WriteLine(sum);     // x + y = 10 + 20 = 30

            ///* Question
            // Shortcut to comment   : Ctrl + K then Ctrl + C
            // Shortcut to uncomment : Ctrl + K then Ctrl + U
            // or we can toggle comment & uncomment by Ctrl + /
            // */
            #endregion

            #region Problem 2
            ////int x = "10";
            ////Console.WriteLine(x + y);
            //// First thing we assign a string to int variable x
            //// Second we use variable y which is not declared anywhere
            //// Fix :
            //int x = 10;
            //int y = 20;
            //Console.WriteLine(x + y);

            ///*  Question
            // The difference between runtime error & logical error :
            // runtime error : occurs after compiling the code successfully, when we run the program,
            //                 somethign happens that makes the program crash, like dividing by zero, accessing null object, open file not found.
            // logical error : occurs when the program runs without any crash, but there is a mistake in the business logic,
            //                 like using wrong formula, wrong condition in if statement.
            // */ 
            #endregion

            #region Problem 3

            //// Full Name 
            //String FullName = "Mohamed Kotb";

            //// Age 
            //int Age = 21;

            //// Salary
            //double Salary = 12345.55;

            //// Is Student
            //bool IsStudent = true;

            ///*  Question
            // it is important to choose nameing conventions, it helps in code readability,
            // and allow other programmers within the team to understand the code easily
            // */

            #endregion

            #region Problem 4

            //Point a = new Point();
            //Point b = new Point();
            //a.x = 10;
            //b.x = 20;
            //Console.WriteLine("a.x: " + a.x + " " + "b.x: " + b.x);
            //a = b;
            //b.x = 30;
            //Console.WriteLine("a.x: " + a.x + " " + "b.x: " + b.x);

            //// when we do a = b; we make a points to the same object as b
            //// and when we change b.x, a.x also changes,
            //// because they point to the same object in the heap memory

            ///*  Question : 
            // the difference between value types and reference types :
            // value types : store the actual data directly in the variable in the stack
            //               like int, float, bool.
            // reference types : store a reference (address) in the stack that points to the actual data in the heap
            //                   like objects, arrays, strings.
            // */
            #endregion

            #region Problem 5
            //int x = 15, y = 4;
            //Console.WriteLine("Sum: " + (x + y) );
            //Console.WriteLine("Difference: " + (x - y) );
            //Console.WriteLine("Product: " + (x * y) );
            //Console.WriteLine("Division: " + (x / y) );
            //Console.WriteLine("Reminder: " + (x % y) );

            //// Question
            //// it will be 2, because when we take the division of 2 / 7,
            //// it will be 0 and we add the actual value of 2 to it, so it will
            //// be the same number 2.
            #endregion

            #region Problem 6
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //if( num > 10 && num % 2 == 0)
            //{
            //    Console.WriteLine("The number is greater than 10 and even.");
            //}
            //else if (num > 10 && num % 2 != 0)
            //{
            //    Console.WriteLine("The number is greater than 10 and odd.");
            //}
            //else if (num <= 10 && num % 2 == 0)
            //{
            //    Console.WriteLine("The number is not greater than 10 and even.");
            //}
            //else
            //{

            //    Console.WriteLine("The number is not greater than 10 and not even.");
            //}

            ///* Question
            //   Logical And (&&): works with boolean expressions, use short circuit evaluation,
            //                     if the first operand is false, it does not evaluate the second operand.
            //   Bitwise And (&): works with integer types at the bit level, use long circuit evaluation,
            //                    always evaluates both operands.

            // */

            #endregion

            #region Problem 7
            //Console.Write("Enter a double number: ");
            //double num = double.Parse(Console.ReadLine());

            //// explicit casting
            //int explicitCast = (int)num;

            //// implicit casting
            //double implicitCast = explicitCast;

            //Console.WriteLine("Original double value: " + num);
            //Console.WriteLine("Explicit: " + explicitCast);
            //Console.WriteLine("Implicit: " + implicitCast);

            ///* Question 
            // it is required to do explicit casting from double to int,
            // because there is a possibility of data loss,
            // so we should tell the compiler that we are aware of this data loss            
            // */
            #endregion

            #region Problem 8
            //Console.Write("Enter your age: ");
            //string input = Console.ReadLine();
            //int age = int.Parse(input);
            //if(age > 0 && age < 150)
            //    Console.WriteLine("Age is valid");
            //else
            //{
            //    Console.WriteLine("Age is not valid, it must be between 0 and 150");
            //}
            ///* Question

            //   overflow exception may happens when the user enter a very large number or a very small number
            //   format exception may happens when the user enter a non numeric value
            //   we can handle these exceptions by using try catch block
            //*/
            #endregion

            #region Problem 9
            //int x = 1;
            //Console.WriteLine("Prefix: " + x++); // Prints 1, then x becomes 2
            //Console.WriteLine("Postfix: " + ++x);// prints 3, then x becomes 3


            ///* Question 
            //   int x = 5;
            //   int y = ++x + x++;
            //   the value of x will be 7
            //   the value of y will be 12
            //   because the value of x in y is incremented by preefix before the addition
            //   so it become 6, and then we perform the addition 6 + 6 = 12
            //   then the postfix increment happens after the addition, so x becomes 7
            // */
            #endregion

        }
    }
}
