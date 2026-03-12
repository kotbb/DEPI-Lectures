using day10_G01;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators

            #region Problem 1
            //var res1 = ListGenerators.ProductList.Where((P) => P.UnitsInStock == 0);
            //foreach (var item in res1)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #region Problem 2
            //var res2 = ListGenerators.ProductList.Where((P) => P.UnitsInStock > 0 && P.UnitPrice > 3);
            //foreach (var item in res2)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 3
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", 
            //                 "six", "seven", "eight","nine" };

            //var res3 = Arr.Where((D, I) => D.Length < I);
            //foreach (var item in res3)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #endregion

            #region Element Operators

            #region Problem 1
            //var res1 = ListGenerators.ProductList.FirstOrDefault((P) => P.UnitsInStock == 0);
            //Console.WriteLine(res1); 
            #endregion

            #region Problem 2
            //var res2 = ListGenerators.ProductList.FirstOrDefault((P) => P.UnitPrice > 1000);
            //Console.WriteLine(res2); 
            #endregion

            #region Problem 3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res3 = Arr.Where((X) => X > 5)
            //              .Skip(1)
            //              .FirstOrDefault();
            //Console.WriteLine(res3); 
            #endregion

            #endregion

            #region Aggregate Operators

            #region Problem 1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res1 = Arr.Count((X) => X % 2 != 0);
            //Console.WriteLine(res1); 
            #endregion

            #region Problem 2
            //var res2 = ListGenerators.CustomerList.Select((C) => new
            //{
            //    Name = C.Name,
            //    Orders = C.Orders?.Length ?? 0
            //});

            //foreach (var item in res2)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 4
            //var res3 = ListGenerators.ProductList.GroupBy((P) => P.Category)
            //                                     .Select((C) => new
            //                                     {
            //                                         Category = C.Key,
            //                                         Products = C.Count()
            //                                     });

            //foreach (var item in res3)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res4 = Arr.Sum();
            //Console.WriteLine(res4); 
            #endregion

            #region Problem 5
            //string text = File.ReadAllText("dictionary_english.txt");

            //string[] words = text.Split(' ');
            //var res5 = words.Sum((W) => W.Length);
            //Console.WriteLine(res5); 
            #endregion



            #endregion

            #region Ordering Operators

            #region Problem 1
            //var res1 = ListGenerators.ProductList.OrderBy((P) => P.ProductName.Length);
            //foreach (var item in res1)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 2
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var res2 = Arr.OrderBy((w) => w);
            //foreach (var item in res2)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 3
            //var res3 = ListGenerators.ProductList.OrderByDescending((P) => P.UnitsInStock);

            //foreach (var item in res3)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 4
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
            //                 "nine" };
            //var res4 = Arr.OrderBy((D) => D.Length)
            //              .ThenBy((D) => D);

            //foreach (var item in res4)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 5
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var res5 = words.OrderBy((W) => W.Length)
            //                .ThenBy((W) => W);
            //foreach (var item in res5)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 6
            //var res6 = ListGenerators.ProductList.OrderBy((P) => P.Category)
            //                .ThenByDescending((P) => P.UnitPrice);
            //foreach (var item in res6)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 7
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var res7 = Arr.OrderBy(W => W.Length)
            //              .ThenByDescending(W => W);

            //foreach (var item in res7)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 8
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight",
            //                 "nine" };
            //var res8 = Arr.Where((W) => W[1] == 'i')
            //              .Reverse();

            //foreach (var item in res8)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #endregion

            #region Transformation Operators

            #region Problem 1
            //var res1 = ListGenerators.ProductList.Select((P) => P.ProductName);
            //foreach (var item in res1)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var res2 = words.Select((W) => new
            //{
            //    UpperCase = W.ToUpper(),
            //    LowerCase = W.ToLower(),
            //});
            //foreach (var item in res2)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 3
            //var res3 = ListGenerators.ProductList.Select((P) => new
            //{
            //    Name = P.ProductName,
            //    Price = P.UnitPrice
            //});
            //foreach (var item in res3)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res4 = Arr.Select((N, I) => new 
            //{
            //    Number = N,
            //    InPlace = N == I
            //});
            //foreach (var item in res4)
            //{
            //    Console.WriteLine($"{item.Number}: {item.InPlace}");
            //} 
            #endregion

            #region Problem 5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var res5 = numbersA.SelectMany((A) => numbersB
            //                   .Where((B) => A < B)
            //                   .Select((B) => new
            //                   {
            //                       A,
            //                       B
            //                   }));
            //foreach (var item in res5)
            //{
            //    Console.WriteLine($"{item.A} is less than {item.B}");
            //} 
            #endregion

            #region Problem 6
            //var res6 = ListGenerators.CustomerList.SelectMany((C) => C.Orders)
            //                                      .Where((O) => O.Total < 500);
            //foreach (var item in res6)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 7
            //var res7 = ListGenerators.CustomerList.SelectMany((C) => C.Orders)
            //                                      .Where((O) => O.OrderDate.Year >= 1998);
            //foreach (var item in res7)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #endregion

            #region Partitioning Operators

            #region Problem 1
            //var res1 = ListGenerators.CustomerList.Where((C) => C.City == "Berlin")
            //                                      .SelectMany((C) => C.Orders)
            //                                      .Take(3);

            //foreach (var item in res1)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 2
            //var res2 = ListGenerators.CustomerList.Where((C) => C.City == "Berlin")
            //                                      .SelectMany((C) => C.Orders)
            //                                      .Skip(2);

            //foreach (var item in res2)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res3 = numbers.TakeWhile((N, I) => N >= I);

            //foreach (var item in res3)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res4 = numbers.SkipWhile((N) => N % 3 != 0);

            //foreach (var item in res4)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res5 = numbers.SkipWhile((N,I) => N >= I);

            //foreach (var item in res5)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #endregion

            #region Quantifiers

            #region Problem 1
            //string text = File.ReadAllText("dictionary_english.txt ");

            //string[] words = text.Split(' ');

            //var res1 = words.Where((S) => S.Contains("ei"));
            //foreach (var item in res1)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Problem 2

            //var res2 = ListGenerators.ProductList.GroupBy((P) => P.Category)
            //                                     .Where((C) => C.Any((P) => P.UnitsInStock == 0));
            //foreach (var group in res2)
            //{
            //    Console.WriteLine($"{group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine(product);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Problem 3
            //var res3 = ListGenerators.ProductList.GroupBy((P) => P.Category)
            //                                        .Where((C) => C.All((P) => P.UnitsInStock > 0));
            //foreach (var group in res3)
            //{
            //    Console.WriteLine($"{group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine(product);
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #endregion


        }
    }
}
