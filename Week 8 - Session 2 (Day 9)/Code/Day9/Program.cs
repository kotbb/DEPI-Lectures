using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Day9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ********************** PART 01 *************************
            #region Part 01

            #region Problem 1

            //foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            //{
            //    Console.WriteLine($"{day} : {(int) day}");
            //}

            //// Question: Why is it recommended to explicitly assign values to enum members in some cases?

            //// if you want to ensure that the enum values remain consistent if you add some value in between
            //// or you want to assign specific values that will have meaning

            #endregion

            #region Problem 2

            //foreach (Grades grade in Enum.GetValues(typeof(Grades)))
            //{
            //    Console.WriteLine($"{grade} : {(short)grade}");
            //}

            //// Question: What happens if you assign a value to an enum member that exceeds the underlying type's range?

            //// it will override the enum member that has this value
            //// and it will be duplicated in the enum, as the previous example
            //// we have duplicated F = 1 in the Grades Enum


            #endregion

            #region Problem 3

            //Person p1 = new Person(1, "Mohamed", "HR");
            //Person p2 = new Person(2, "Ahmed", "AI");

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);

            //// Question: What is the purpose of the virtual keyword when used with properties?
            //// it makes the property can be overridden from the derived classes that will inherit from that class
            //// without it, the derived class will not be able to change the implementation of that property

            #endregion

            #region Problem 4

            //Child child = new Child(1, "Kotb", "IT");
            //child.Salary = 8000;

            //child.DisplaySalary();

            //// Question:Why can’t you override a sealed property or method?
            //// because the sealed keyword prevents any overriding of that property or method
            //// in any derived classes that will inherit from that class

            #endregion

            #region Problem 5

            //double perimeter = Utility.CalculateRectanglePerimeter(5, 3);
            //Console.WriteLine($"Perimeter of the Rectangle = {perimeter}");

            //// Question: What is the key difference between static and object members?
            //// Static members belong to the class itself and can be accessed without createing an instance of the class,
            //// while object members belong to instances of the class and require an object to be accessed.
            //// Static members are shared across all instances of the class, while object members can have different values for each instance.


            #endregion

            #region Problem 6

            //ComplexNumber c1 = new ComplexNumber(2, 3);
            //ComplexNumber c2 = new ComplexNumber(4, 5);

            //ComplexNumber result = c1 * c2;
            //Console.WriteLine(result);

            //// Question: Can you overload all operators in C#? Explain why or why not.
            //// no, you cannot overload all operators in C#.
            //// Some operators, such as the assignment operator (=), the conditional logical operators (&&, ||), and the null-coalescing operator (??), cannot be overloaded.
            //// This is because these operators have specific behaviors that are related to the language and cannot be changed without breaking the fundamental principles of C#.

            #endregion

            #region Problem 7

            //Console.WriteLine($"Size of GenderInt  : {sizeof(GenderInt)} bytes");
            //Console.WriteLine($"Size of GenderByte : {sizeof(GenderByte)} bytes");

            //// Question: When should you consider changing the underlying type of an enum?
            //// when you want to optimize memory usage, and use a smaller type or larger type
            //// based on the range of values you expect

            #endregion

            #region Problem 8

            //double celsius = 25;

            //Console.WriteLine(Utility.ConvertCelsiusToFahrenheit(celsius));

            //// Question: Why can't a static class have instance constructors?

            //// because a static class cannot be instantiated, so it cannot have instance constructors.

            #endregion

            #region Problem 9

            //Console.Write("Enter grade: ");
            //string input = Console.ReadLine();

            //if(Enum.TryParse(input, out Grades grade))
            //{
            //    Console.WriteLine($"You entered grade: {grade}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid grade input.");
            //}

            //// Question: What are the advantages of using Enum.TryParse over direct parsing with int.Parse?
            //// TryParse is more safe and handels the invalid input without throwing exceptions.

            #endregion

            #region Problem 10

            //Helper2<Employee> helper = new Helper2<Employee>();

            //Employee[] employees =
            //{
            //    new Employee ( 1, "Ahmed"),
            //    new Employee ( 2, "Sara"),
            //    new Employee ( 3, "Omar")
            //};

            //Employee searchEmployee = new Employee(2, "Sara", "AI");

            //int index = Helper2<Employee>.SearchArr(employees, searchEmployee);

            //if (index != -1)
            //{
            //    Console.WriteLine($"Employee found at index: {index}");
            //}
            //else
            //{
            //    Console.WriteLine("Employee not found.");
            //}
            //// without the override of Equals, it will return -1 not found, because it will compare
            //// the reference of the object no the content

            //// Question: What is the difference between overriding Equals and == for object comparison in C# struct and class ?

            //// Before Override: Equals in class compares the reference of the object, while in struct it compares the content of the struct.
            ////                  == in class is the same as Equals, but in struct is not defined by default
            //// Equals resolved at runtime as it is virtual method, while == is resolved at compile time as it is an operator.

            //// Question: Why is overriding ToString beneficial when working with custom classes?
            //// allow to provide a meaningful string representation of the object, which can be used Console.write

            #endregion

            #region Problem 11

            //int MaxInt = Helper2<int>.Max(10, 25);
            //double MaxDouble = Helper2<double>.Max(1.5, 2.3);
            //string MaxString = Helper2<string>.Max("abc", "ab");

            //Console.WriteLine($"Max Integer: {MaxInt}");
            //Console.WriteLine($"Max Double: {MaxDouble}");
            //Console.WriteLine($"Max String: {MaxString}");

            //// Question: Can generics be constrained to specific types in C#? Provide an example.
            //// yes you can constrain generics to specific types using the where keyword.
            //// For example, in the Helper2 class, we have constrained the generic type T to types that implement the IComparable<T> interface.
            //// This allows us to use the CompareTo method to compare values of type T in the Max method.

            #endregion

            #region Problem 12

            //int[] numbers = { 1, 2, 3, 2, 4, 2 };
            //Helper2<int>.ReplaceArray(numbers, 2, 99);

            //foreach (var n in numbers)
            //{
            //    Console.Write(n + " ");
            //}

            //// Question: What are the key differences between generic methods and generic classes?
            //// Generic Class, it is specified when intializing the class, and all its methods will use the same generic type
            //// While Generic Method, it is specified when calling the method,
            //// and each method can use different generic type.

            #endregion

            #region Problem 13

            //Rectangle Rect1 = new Rectangle(10, 5);
            //Rectangle Rect2 = new Rectangle(20, 8);

            //Console.WriteLine("Before Swap:");
            //Console.WriteLine($"Rectangle 1: {Rect1}");
            //Console.WriteLine($"Rectangle 2: {Rect2}");

            //Rectangle.Swap(ref Rect1, ref Rect2);

            //Console.WriteLine("\nAfter Swap:");
            //Console.WriteLine($"Rectangle 1: {Rect1}");
            //Console.WriteLine($"Rectangle 2: {Rect2}");

            //// Question: Why might using a generic swap method be preferable to implementing custom methods for each type?

            //// to make the method reusable for any type, and to avoid code duplication,
            //// this improves flexibility and maintainablitiy of the code

            #endregion

            #region Problem 14

            //Department d1 = new Department { Id = 1, Name = "HR" };
            //Department d2 = new Department { Id = 2, Name = "IT" };

            //Employee[] employees =
            //{
            //    new Employee( 1, "Ali", d1),
            //    new Employee( 2, "Omar", d2),
            //};

            //Department[] departments =
            //{
            //    employees[0].Department,
            //    employees[1].Department,
            //};

            //Department SearchDept = new Department { Id = 2, Name = "IT" };

            //int index = Helper2<Department>.SearchArr(departments, SearchDept);

            //if(index == 1)
            //{
            //    Console.WriteLine($"Department found at {index}");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");
            //}

            //// Question: How can overriding Equals for the Department class improve the accuracy of searches?
            //// we can easily determine by comparing the content of the department, not the reference

            #endregion

            #region Problem 15

            //Circle c1 = new Circle(10, "Red");
            //Circle c2 = new Circle(10, "Red");

            //// if (c1 == c2) // gives error
            //if (c1.Equals(c2)) 
            //{
            //    Console.WriteLine("Circles are the same");            
            //}
            //else
            //{
            //    Console.WriteLine("Circles are not the same");
            //}

            //// in Class, both work fine but without overriding they will compare with refernce so the result will be not equal
            //// but in struct, == not work by default.

            //// Question: Why is == not implemented by default for structs?
            //// because .NET does not know how to compare the structs by default, as it is a value type
            //// and it differs based on the buisness casses and the system so they avoid this thing

            #endregion

            #endregion


            // ********************** PART 02 *************************

            #region Part 02

            #region 2- What we mean by Generalization concept using Generics?

            // when we use Generics methods or classes, we are applying the Generalization concept
            // as we are creating a general method or class that can work with any type


            #endregion

            #region 3- What we mean by hierarchy design in real business ?

            // reflects the real world hiarachy in the buisness, for example we have a base class Employee,
            // and we have derived classes like Manager, Developer, Intern etc.

            #endregion


            #region Problem 1 : Generic Method for Reversing an Array

            //int[] Numbers = { 1, 2, 3, 4, 5 };
            //string[] Strings = { "Hello", "World", "Generics" };

            //ReverseArray(Numbers);
            //ReverseArray(Strings);

            //foreach (var n in Numbers)
            //    Console.Write(n + " ");

            //Console.WriteLine();

            //foreach (var s in Strings)
            //    Console.Write(s + " ");

            #endregion

            #region Problem 2: Generic Class for a Stack

            //Stack<int> s = new Stack<int>();

            //s.Push(10);
            //s.Push(20);
            //s.Push(30);

            //Console.WriteLine(s.Peek()); 
            //Console.WriteLine(s.Pop());  
            //Console.WriteLine(s.Pop());  


            #endregion

            #region Problem 3 : Generic Method for Swapping Elements

            //int[] Numbers = { 10, 20, 30, 40 };
            //string[] Strings = { "A", "B", "C", "D" };

            //Swap(Numbers, 1, 3);
            //Swap(Strings, 1, 3);

            //foreach (var n in Numbers)
            //    Console.Write(n + " ");

            //Console.WriteLine();

            //foreach (var s in Strings)
            //    Console.Write(s + " ");


            #endregion

            #region Problem 4: Generic Method for Finding the Maximum Value

            //int[] Numbers = { 10, 20, 30, 40 };

            //Console.WriteLine(Max<int>(Numbers));

            #endregion

            #endregion

            // ********************** PART 03 (Bonus) *************************

            #region Part 03

            #region 2- What is the Event driven Programming ?

            // it is a way of system or design that is based on events or actions that make the system respond
            // to them and perform actions based on that, for example in GUI applications, when the user clicks a button,
            // it triggers an event that the system responds to by executing a specific method or action.
            // or in Youtube when a channel that you are subscribed to uploads a new video,
            // it triggers an event that you get notified about it and you can watch it.

            #endregion

            #endregion

        }

        #region Problem 1 : Generic Method for Reversing an Array

        public static void ReverseArray<T>(T[] Arr)
        {
            int Left = 0;
            int Right = Arr.Length - 1;
            while(Left < Right) 
            {
                T Temp = Arr[Left];
                Arr[Left] = Arr[Right];
                Arr[Right] = Temp;
                Left++;
                Right--;
            }

        }

        #endregion

        #region Problem 3 : Generic Method for Swapping Elements

        public static void Swap<T>(T[] Arr, int index1, int index2)
        {

            if (index1 == index2 || index1 < 0 ||
                index1 >= Arr.Length || index2 < 0 || 
                index2 >= Arr.Length)
            {
                return;
            }

            T Temp = Arr[index1];
            Arr[index1] = Arr[index2];
            Arr[index2] = Temp;
        }

        #endregion

        #region Problem 4: Generic Method for Finding the Maximum Value

        public static T Max<T>(T[]Arr) where T : IComparable<T>
        {
            if (Arr == null || Arr.Length == 0)
                throw new ArgumentException("Array cannot be null or empty.");
            T MaxValue = Arr[0];
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i].CompareTo(MaxValue) > 0)
                {
                    MaxValue = Arr[i];
                }
            }
            return MaxValue;
        }

        #endregion

    }
}
