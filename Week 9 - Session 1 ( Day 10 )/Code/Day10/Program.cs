using System;
using System.Collections.Generic;
using System.Linq;
using static Day10.Program;

namespace Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *********************** PART 01 ***********************
            #region Part 01

            #region Problem 1

            //Employee[] Emps =
            //{
            //    new Employee(1,"Ali",4567),
            //    new Employee(2,"Abdo",9567),
            //    new Employee(3,"Ismail",3567)
            //};
            //foreach (Employee item in Emps)
            //    Console.WriteLine(item);
            //Console.WriteLine();
            //SortingAlgorithm<Employee>.Sort(Emps);
            //foreach (Employee item in Emps)
            //    Console.WriteLine(item);

            //// Question: What are the benefits of using a generic sorting algorithm over a non-generic one?
            //// improves reusability and flexibility, that you can sort any type not specific type

            #endregion

            #region Problem 2

            //int[] nums = { 3, 1, 2 };

            //foreach (int item in nums)
            //    Console.WriteLine(item);
            //Console.WriteLine();
            //SortingTwo<int>.Sort(nums, (X, Y) => X < Y);
            //foreach (int item in nums)
            //    Console.WriteLine(item);

            //// Question: How do lambda expressions improve the readability and flexibility of sorting methods?
            //// it makes the syntax to be sugar and more readable and allow us to easily pass function
            //// to another function

            #endregion

            #region Problem 3

            //string[] strings = { "Abcd", "Ab", "Abc" };

            //foreach (var item in strings)
            //    Console.WriteLine(item);
            //Console.WriteLine();
            //SortingTwo<string>.Sort(strings, (X, Y) => X.Length > Y.Length);
            //foreach (var item in strings)
            //    Console.WriteLine(item);

            //// Question: Why is it important to use a dynamic comparer function when sorting objects of various data types?
            //// to allow flexiblity in the buisness and logic and make it more dynamically

            #endregion

            #region Problem 4

            //Manager[] Mangs =
            //{
            //    new Manager(1,"Ali",4567),
            //    new Manager(2,"Abdo",9567),
            //    new Manager(3,"Ismail",3567)
            //};
            //foreach (var item in Mangs)
            //    Console.WriteLine(item);
            //Console.WriteLine();
            //SortingAlgorithm<Manager>.Sort(Mangs);
            //foreach (var item in Mangs)
            //    Console.WriteLine(item);

            //// Question: How does implementing IComparable<T> in derived classes enable custom sorting?
            //// it defines how objects compares each other to allow reusability

            #endregion

            #region Problem 5

            //Employee[] Emps =
            //{
            //    new Employee(3,"Ismail",3567),
            //    new Employee(1,"Ali",4567),
            //    new Employee(2,"Abdo",9567)
            //};
            //Func<Employee, Employee, bool> CompareByLength = 
            //  (x,y) => x.Name.Length > y.Name.Length;

            //foreach (Employee item in Emps)
            //    Console.WriteLine(item);
            //Console.WriteLine();
            //SortingTwo<Employee>.Sort(Emps, CompareByLength);
            //foreach (Employee item in Emps)
            //    Console.WriteLine(item);

            //// Question: What is the advantage of using built-in delegates like Func<T, T, TResult> in generic programming ?
            //// it makes it easier to use and more flexible rather than making a custom delegate
            //// you now have one Generic Type like Func that can take 16 parameters and you can 
            //// easily use it in lambda

            #endregion

            #region Problem 6

            //int[] nums = { 4, 5, 2, 1, 3 };
            //foreach (int item in nums)
            //    Console.WriteLine(item);
            //Console.WriteLine();
            ////SortingTwo<int>.Sort(nums, delegate (int x, int y)
            ////{
            ////    return x > y;
            ////});
            //SortingTwo<int>.Sort(nums, (x,y) => x > y);

            //foreach (int item in nums)
            //    Console.WriteLine(item);

            //// Question:How does the usage of anonymous functions differ from lambda expressions in terms of readability and efficiency ?
            //// Lambda expressons more short and clean so it is more readable
            //// in Performance, they are the same, Lambda is converted behind the scenes to delegate and then
            //// delegate converted into class

            #endregion

            #region Problem 7

            //already made in the SortingAlgorithm class.

            // Question: Why is the use of generic methods beneficial when creating utility functions like Swap?
            // to allow reusability and not duplicate the method, this makes you can swap
            // any type not specific type only

            #endregion

            #region Problem 8

            //Employee[] employees =
            //{
            //    new Employee(1, "Ali", 5000),
            //    new Employee(2, "Mohamed", 7000),
            //    new Employee(3, "Omar", 5000),
            //    new Employee(4, "Youssef", 7000)
            //};

            //foreach (Employee emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}
            //Console.WriteLine();

            //SortingAlgorithm<Employee>.Sort(employees);
            //foreach (Employee emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}

            //// Question: What are the challenges and benefits of implementing multi-criteria sorting logic in generic methods?

            //// affects performance and may be harder to maintain after that
            //// benifits: it makes your sort is more realistic and you can apply your buisness logic


            #endregion

            #region Problem 9

            //int defaultInt = GetDefault<int>();
            //string defaultString = GetDefault<string>();
            //bool defaultBool = GetDefault<bool>();

            //Console.WriteLine($"{defaultInt}, {defaultString}, {defaultBool}");

            //// Question: Why is the default(T) keyword crucial in generic programming,
            //// and how does it handle value and reference types differently ?
            //// you can use it with handeling default values in methods for value types like return null for string, 0 for int
            //// so you can easily use return default(), also in reference type it will return null

            #endregion

            #region Problem 10

            //Employee[] employees =
            //{
            //    new Employee(1, "Ali", 5000),
            //    new Employee(2, "Mohamed", 7000),
            //    new Employee(3, "Omar", 4000)
            //};

            //Employee[] clonedEmployees = new Employee[employees.Length];

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    clonedEmployees[i] = (Employee)employees[i].Clone();
            //}

            //// Sort cloned array
            //SortingAlgorithm<Employee>.Sort(clonedEmployees);

            //Console.WriteLine("Original Array:");
            //foreach (var emp in employees)
            //    Console.WriteLine(emp);

            //Console.WriteLine("\nCloned & Sorted Array:");
            //foreach (var emp in clonedEmployees)
            //    Console.WriteLine(emp);


            //// Question: How do constraints in generic programming ensure type safety and improve the reliability of generic methods?

            //// They ensure type safety at compile type when using generic and prevent passing any type
            //// that not apply these constraints

            #endregion

            #region Problem 11

            //List<string> names = new List<string>
            //{
            //    "mohamed",
            //    "ahmed",
            //    "ali"
            //};
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //List<String> upper = TransformList(names, (n) => n.ToUpper());
            //foreach (var item in upper)
            //{
            //    Console.WriteLine(item);
            //}

            //// Question: What are the benefits of using delegates for string transformations in a functional programming style?
            //// flexiblity, reuasability, instead of making many functions that make many behaviousrs
            //// you can make one function and adjust the behaviour with the delegate and lambda function

            #endregion

            #region Problem 12

            //int i1 = 6; 
            //int i2 = 3;
            //int add = Calculate(i1, i2, (n1, n2) => n1 + n2);
            //int sub = Calculate(i1, i2, (n1, n2) => n1 - n2);
            //int mult = Calculate(i1, i2, (n1, n2) => n1 * n2);
            //int div = Calculate(i1, i2, (n1, n2) => n1 / n2);

            //Console.WriteLine($"Addition: {add}");
            //Console.WriteLine($"Subtraction: {sub}");
            //Console.WriteLine($"Multiplication: {mult}");
            //Console.WriteLine($"Division: {div}");

            //// Question: How does the use of delegates promote code reusability and flexibility in implementing mathematical operations?
            //// it gives you the flexibility to change the behaviour at runtime as you wants
            //// it make your code reusable instead of making function for every operation in the above example

            #endregion

            #region Problem 13

            //List<int> numbers = new List<int> { 1, 2, 3, 4 };
            //List<string> strings = Transform<int,string>(numbers, n => n.ToString());

            //foreach (var item in strings)
            //{
            //    Console.WriteLine(item);
            //}

            //// Question: What are the advantages of using generic delegates in transforming data structures?
            //// Type Safety, flexibility, reusability

            #endregion

            #region Problem 14

            //Func<int, int> square = x => x * x;

            //List<int> numbers = new List<int> { 1, 2, 3, 4 };
            //List<int> squares = ConvertToSquare(numbers, square);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //foreach (var item in squares)
            //{
            //    Console.WriteLine(item);
            //}

            //// Question: How does Func simplify the creation and usage of delegates in C#?
            //// it gives you a one delegate that has like 17 version, it takes up to 17 parameters
            //// so it has the flexilbility and simplify the creation of user defined delegate

            #endregion

            #region Problem 15

            //Action<string> print = s => Console.WriteLine(s);

            //List<string> list = new List<string>{"Mohamed", "Mazen", "Kotb"};

            //printStringList(list, print);

            //// Question: Why is Action preferred for operations that do not return values?
            //// because it doesn't take a parameter for out or return values, so it is mostly
            //// used in void functions 

            #endregion

            #region Problem 16

            //Predicate<int> CheckEven = n => n % 2 == 0;
            //List<int> numbers = new List<int> { 1, 2, 3, 4 };

            //List<int> evenNums = FilterEven(numbers, CheckEven);

            //foreach (var item in evenNums)
            //{
            //    Console.WriteLine(item);
            //}

            //// Question: What role do predicates play in functional programming, and how do they enhance code clarity ?
            //// because they are taking one parameter only everytime and return bool true or false
            //// so they used to check if this parameter satisfy some condition

            #endregion

            #region Problem 17

            //List<string> strings = new List<string> { "Mohamed", "abc", "med", "abcd" };

            //List<string> startsWithA = FilterStrings(strings, str => str[0] == 'a');

            //foreach (var item in startsWithA)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //List<string> containsMed = FilterStrings(strings, str => str.Contains("med"));

            //foreach (var item in containsMed)
            //{
            //    Console.WriteLine(item);
            //}

            //// Question: How do anonymous functions improve code modularity and customization?
            //// it allows the code to be more readable and instead of making a whole function
            //// to startWithA, we make it inside the function by the delegate Func

            #endregion

            #region Problem 18

            //int i1 = 6;
            //int i2 = 2;
            //int add = PerformOperation(i1,i2, (x,y) => x + y);
            //int sub = PerformOperation(i1,i2, (x,y) => x - y);
            //int mult = PerformOperation(i1,i2, (x,y) => x * y);
            //int div = PerformOperation(i1,i2, (x,y) => x / y);

            //Console.WriteLine($"Add : {add}");
            //Console.WriteLine($"Sub : {sub}");
            //Console.WriteLine($"Mult : {mult}");
            //Console.WriteLine($"Div : {div}");

            //// Question: When should you prefer anonymous functions over named methods in implementing mathematical operations?
            //// it improves the simlicity of the code and make it more readable

            #endregion

            #region Problem 19

            //List<string> list = new List<string> { "Mohamed", "Maz", "Kotb" };

            //List<string> filteredList = FilterStrings(list, str => str.Length > 3 ||
            //                                          str.Contains('e'));

            //foreach (var item in filteredList)
            //{
            //    Console.WriteLine(item);
            //}

            //// Question: What makes lambda expressions an essential feature in modern C# programming?
            //// they allow functions to pass as parameters, store functions in variables,
            //// and make the code more readable

            #endregion

            #region Problem 20

            //double d1 = 3.6;
            //double d2 = 1.4;


            //double div = PerformOperationDouble(d1, d2, (n1, n2) => n1 / n2);
            //Console.WriteLine(div);

            //double pow = PerformOperationDouble(d1, d2, (n1, n2) => Math.Pow(n1,n2));
            //Console.WriteLine(pow);

            //// Question: How do lambda expressions enhance the expressiveness of mathematical computations in C#
            //// instead of making a function to each operation, we make a generic one that takes
            //// lambda or anonymous function and perform it at runtime based on the given behaviour

            #endregion

            #endregion
        }

        // *********************** PART 01 ***********************

        #region Part 01

        #region Problem 9

        public static T GetDefault<T>()
        {
            return default(T);
        }

        #endregion

        #region Problem 11

        public delegate string StringTransform(string input);
        public static List<String> TransformList(List<String> input, StringTransform transform)
        {
            List<String> result = new List<String>();

            foreach (var item in input) 
            { 
                result.Add(transform(item));
            }
            return result;
        }
        #endregion

        #region Problem 12

        public delegate int intOperation(int i1, int i2);

        public static int Calculate(int i1, int i2, intOperation operation) 
        { 
            return operation(i1, i2);
        }

        #endregion

        #region Problem 13

        public delegate R transformer<T, R>(T input);
        public static List<R> Transform<T, R>(List<T> input, transformer<T,R> trans)
        {
            List<R> result = new List<R>();
            foreach (var item in input)
            {
                result.Add(trans(item));
            }
            return result;
        }

        #endregion

        #region Problem 14

        public static List<int> ConvertToSquare(List<int> input, Func<int,int> sq) 
        {
            List<int> result = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                result.Add(sq(input[i]));
            }
            return result;
        }

        #endregion

        #region Problem 15

        public static void printStringList(List<string> input, Action<string> pr)
        {
            foreach (var item in input)
            {
                pr(item);
            }
        }


        #endregion

        #region Problem 16

        public static List<int> FilterEven(List<int> input, Predicate<int> chk) 
        {
            List<int> result = new List<int>();

            foreach (var item in input)
            {
                if(chk(item))
                    result.Add(item);
            }
            return result;
        }

        #endregion

        #region Problem 17

        public static List<string> FilterStrings(List<string> input, Func<string,bool> filter)
        {
            List<string> result = new List<string>();
            foreach (var item in input)
            {
                if(filter(item))
                    result.Add(item);
            }
            return result;
        }

        #endregion

        #region Problem 18

        public static int PerformOperation(int i1, int i2, Func<int,int,int> fn)
        {
            return fn(i1,i2); 
        }

        #endregion

        #region Problem 20

        public static double PerformOperationDouble(double d1, double d2, Func<double, double, double> fn)
        {
            return fn(d1, d2);
        }

        #endregion

        #endregion
    }
}
