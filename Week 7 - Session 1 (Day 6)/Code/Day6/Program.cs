using System;
using System.Formats.Asn1;
using System.Security.Cryptography;

namespace Day6
{
    internal class Program
    {

        #region Problem 6

        static void ModifyPoint(Point p)
        {
            p.X = 100;
            p.Y = 200;
        }

        static void ModifyEmployee(Employee e)
        {
            e.Name = "Ahmed";
            e.Salary = 9000;
        }

        #endregion


        static void Main(string[] args)
        {
            // *************** PART 01 ****************

            #region Part 01

            #region Problem 1

            //Point P1 = new Point();
            //Point P2 = new Point(1,2);
            //Console.WriteLine($"Point 1 with default Ctor: {P1}");
            //Console.WriteLine($"Point 2 with Parametrized Ctor: {P2}");

            //// Question: Why can't a struct inherit from another struct or class in C#? 
            //// because they are value type and they are stored in stack
            //// and they are not reference type like class which are stored in heap
            //// and inheritance includes polymorphism which is not supported in value type

            #endregion

            #region Problem 2

            //TypeA a1 = new TypeA();
            //// a1.F = 'A';      Cannot access, it is private
            //a1.G = 'B';
            //a1.H = 'C';

            //// Question: How do access modifiers impact the scope and visibility of a class member?  
            //// it controls the access level of class members.

            #endregion

            #region Problem 3

            //Employee emp1 = new Employee();

            //emp1.SetEmpId(1);
            //emp1.SetName("Mohamed");
            //emp1.SetSalary(1500);

            //Console.WriteLine($"The Name of the Employee: {emp1.GetName()}");

            //Console.WriteLine($"The full details of the Empolyee:");
            //Console.WriteLine(emp1);

            //// Question: Why is encapsulation critical in software design?  
            //// it helps to protect the data and the implementation details of a class from
            //// being accessed or modified by other classes, which can lead to better maintainability, flexibility, and security of the software.

            #endregion

            #region Problem 4

            //Point p1 = new Point(3, 4);
            //Console.WriteLine($"The Point p1: {p1}");

            //Point p2 = new Point(5);
            //Console.WriteLine($"The Point p2: {p2}");

            //// Question: what is constructors in structs?  
            //// A constructor is a special method used to initialize a new instance of a struct
            //// They cannot have a parameterless constructor before C# 10 / .NET 5.
            //// They cannot inherit from another struct or class,


            #endregion

            #region Problem 5

            //Point p1 = new Point(1, 2);
            //Point p2 = new Point(3, 4);
            //Point p3 = new Point(5, 6);

            //Console.WriteLine($"Point 1: {p1}");
            //Console.WriteLine($"Point 2: {p2}");
            //Console.WriteLine($"Point 3: {p3}");

            //// Question: How does overriding methods like ToString() improve code readability?  
            //// if you don't override the ToSTring method, it will return the type name of the struct
            //// which is not useful, I need full description for my struct, so I can override the ToString method to return a string representation of the struct.


            #endregion

            #region Problem 6

            //Point p1 = new Point(1, 2);

            //Console.WriteLine($"Before ModifyPoint: {p1}");
            //ModifyPoint(p1);
            //Console.WriteLine($"After ModifyPoint: {p1}");

            //Employee emp1 = new Employee(1, "Mohamed", 1500);

            //Console.WriteLine($"Before ModifyEmployee: {emp1}");
            //ModifyEmployee(emp1);
            //Console.WriteLine($"After ModifyEmployee: {emp1}");

            //// Question: How does memory allocation differ for structs and classes in C#? 
            //// Struct stored in stack, class stored in heap.
            //// struct Contains actual data as it is value type, while class contains reference to the data
            //// struct passed by value, class passed by reference


            #endregion

            #endregion


            // *************** PART 02 ****************

            #region Part 02

            // 1. What is the copy constructor ?

            // used to create a new object as a copy of an existing object
            // It initializes a new instance using the values of an existing instance.

            // 2. What is Indexer, when used, as business mention cases u have to utilize it? 

            // it is used to access elements in a class like it is an array
            // with [] operator, but actually it is still class, it is a way only
            // buisness cases: when you have a collection of data and you want to access it in a way
            // like EmployeeCollection to access empolyee, and you can specify the name or id to access the empolyee

            // 3. keywords
            // this: used to refer to the current instance of the class
            // value: used in the full property to refer to the value being assigned to the 
            // set: used to assign the value to the property
            // get: used to return the value of the property

            #endregion


        }
    }

    #region Problem 3

    //internal struct Employee
    //{
    //    private int _empId;
    //    private string _name;
    //    private decimal _salary;

    //    public Employee(int empId, string name, decimal salary)
    //    {
    //        _empId = empId;
    //        _name = name;
    //        _salary = salary;
    //    }

    //    public int GetEmpId()
    //    {
    //        return _empId;
    //    }
    //    public void SetEmpId(int empId)
    //    {
    //        _empId = empId;
    //    }
    //    public string GetName()
    //    {
    //        return _name;
    //    }
    //    public void SetName(string name)
    //    {
    //        _name = name;
    //    }
    //    public decimal GetSalary()
    //    {
    //        return _salary;
    //    }
    //    public void SetSalary(decimal salary)
    //    {
    //        _salary = salary;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Employee ID: {_empId}, Name: {_name}, Salary: {_salary}";
    //    }
    //}

    #endregion

}
