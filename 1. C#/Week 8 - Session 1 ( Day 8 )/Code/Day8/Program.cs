using System;
using System.Text;

namespace Day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ************************* PART 01 *************************

            #region Part 01

            #region Problem 1

            //IVechicle v1 = new Car();
            //IVechicle v2 = new Bike();

            //v1.StartEngine();
            //v1.StopEngine();

            //v2.StartEngine();
            //v2.StopEngine();

            //// Question: Why is it better to code against an interface rather than a concrete class?
            //// it gives you the flexibility and scalbility, and easy to change and add more features
            //// in the future, it apply the generilization princible to allow a function accept the interface
            //// and at the runtime it will be converted to the actual concerte class that will be passed

            #endregion

            #region Problem 2

            //Shape s1 = new Rectangle(5, 4);
            //Shape s2 = new Circle(3);

            //s1.Display();
            //s2.Display();


            //// Question: When should you prefer an abstract class over an interface?
            //// when you want to share a common code, and then the abstract class will be like container
            //// for that common code

            #endregion

            #region Problem 3

            //Product[] arr =
            //    {
            //        new Product() { Id = 2, Name = "P2", Price = 20 },
            //        new Product() { Id = 1, Name = "P1", Price = 10 },
            //        new Product() { Id = 3, Name = "P3", Price = 40 },
            //    };
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Array.Sort(arr);

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //// Question: How does implementing IComparable improve flexibility in sorting?
            //// it allows you to sort the array of the object that implements this interface,
            //// based on what you want to compare, and what the buisness wants

            #endregion

            #region Problem 4

            //Student s1 = new Student(1, "S1", 90);
            //Student s2 = new Student(2, "S2", 70);

            //// Shallow Copy
            //s2 = s1;

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s1.GetHashCode());
            //Console.WriteLine(s2.GetHashCode());
            //// Same hash code because they are the same object in memory

            //// Deep Copy
            //Student s3 = new Student(s1);

            //Console.WriteLine(s1);
            //Console.WriteLine(s3);
            //Console.WriteLine(s1.GetHashCode());
            //Console.WriteLine(s3.GetHashCode());
            //// Different hash code because they are different objects in memory

            //// Question: What is the primary purpose of a copy constructor in C#?
            //// to create a new object that is a copy of an existing object, and it is used to implement deep copy


            #endregion

            #region Problem 5

            //Robot robot = new Robot();
            //robot.Walk();

            //IWalkable iw = new Robot();
            //iw.Walk();

            //// Question: How does explicit interface implementation help in resolving naming conflicts?

            //// it allows a class to implement methods with the same name and signature from different interfaces without ambiguity.

            #endregion

            #region Problem 6

            //Account acc1 = new Account(1, "Mohamed", 1000);

            //Console.WriteLine(acc1.AccountId);
            //Console.WriteLine(acc1.AccountHolder);
            //Console.WriteLine(acc1.Balance);

            //// Question: What is the key difference between encapsulation in structs and classes?
            //// Structs encapsulate data as value types, while classes encapsulate data as reference types.

            //// Question: what is abstraction as a guideline, what’s its relation with encapsulation ?
            //// Abstraction : expose what an object does, not how it does it.
            //// Focus on essential behavior, Hide unnecessary details
            //// Encapsulation: hide the internal state to protect withing the security.



            #endregion

            #region Problem 7

            // requires C# 8.0 or later to override the default implementatin methods in the interface

            #endregion

            #region Problem 8

            //Book b1 = new Book();
            //Book b2 = new Book("Book 2");
            //Book b3 = new Book("Book 3", "Kotb");

            //Console.WriteLine(b1);
            //Console.WriteLine(b2);
            //Console.WriteLine(b3);

            //// Question: How does constructor overloading improve class usability?
            //// it allows you to create multiple objects with different sets of parameters,
            //// it gives you flexibility.


            #endregion

            #endregion

            // ************************* PART 02 *************************

            #region Part 02
            #region Question 2

            // 2. What we mean by coding against interface rather than class ? and if u get it so
            //    What we mean by code against abstraction not concreteness ?

            // Code should depend on an interface or abstract class, not on a concrete class.
            // Coding against abstraction means depending on what something does, not how it does it.
            // and this apply the Dependency Inversion Principle, which is one of the SOLID principles,
            // and it states that high-level modules should not depend on low-level modules.
            // Both should depend on abstractions.

            #endregion

            #region Question 3

            // 3. What is abstraction as a guideline and how we can implement this through what we have studied ?

            // abstraction depends on what the system does and neglect how it does it,
            // it focus on essential behavior, Hide unnecessary details
            // we use interfaces, abstract classes or methods or properties, overloading, polymorphism
            // to implement abstraction.


            #endregion

            #region Shape Series

            //IShapeSeries squareSeries = new SquareSeries();
            //IShapeSeries circleSeries = new CircleSeries();

            //PrintTenShapes(squareSeries);
            //PrintTenShapes(circleSeries);

            #endregion

            #region Sorting for Shapes

            //Shape2[] arr = {
            //    new Shape2() { Name = "Rectangle", Area = 20 },
            //    new Shape2() { Name = "Square", Area = 10 },
            //    new Shape2() { Name = "Circle", Area = 40 }
            //};

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine("---------------------------------");
            //Array.Sort(arr);

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            #endregion

            #region Extend Shape Hierachy

            //GeometricShape triangle = new TriangleGeo(10, 5);
            //GeometricShape rectangle = new RectangleGeo(4, 6);

            //Console.WriteLine("Triangle:");
            //Console.WriteLine($"Area = {triangle.CalculateArea()}");

            //Console.WriteLine("\nRectangle:");
            //Console.WriteLine($"Area = {rectangle.CalculateArea()}");
            //Console.WriteLine($"Perimeter = {rectangle.Perimeter}");

            #endregion

            #region Selection Sort for Shapes

            //Shape2[] arr = {
            //    new Shape2() { Name = "Rectangle", Area = 20 },
            //    new Shape2() { Name = "Square", Area = 10 },
            //    new Shape2() { Name = "Circle", Area = 40 },
            //    new Shape2() { Name = "Triangle", Area = 30 },
            //};

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //SelectionSort(arr);

            //Console.WriteLine("-------------------------------");

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            #endregion

            #endregion

        }
        #region PrintTenShapes Function

        public static void PrintTenShapes(IShapeSeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                series.GetNextArea();
                Console.WriteLine(series);
            }
            series.ResetSeries();
        }

        #endregion


        #region SelectionSort for Shapes

        public static void SelectionSort(Shape2[] shapes)
        {

            for (int i = 0; i < shapes.Length - 1; i++)
            {
                for (int j = 0; j < shapes.Length - i - 1; j++)
                {
                    if (shapes[j].Area > shapes[j + 1].Area)
                    {
                        Shape2 temp = shapes[j];
                        shapes[j] = shapes[j + 1];
                        shapes[j + 1] = temp;
                    }
                }
            }

        }
        #endregion






    }
}
