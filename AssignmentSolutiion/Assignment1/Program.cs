using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using static Assignment1.ListGenerator;
namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operators
            ////1
            //var result = ProductList.Where(p => p.UnitsInStock == 0).First();
            // Console.WriteLine(result);

            ////2
            //var result1 = ProductList.FirstOrDefault(p => p.UnitPrice > 100);
            //Console.WriteLine(result1);

            ////3 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result2 = Arr.Where(i => i > 5).Skip(1).FirstOrDefault(); //8
            //Console.WriteLine(result2);
            #endregion

            #region Aggregate Operators
            ////1. Uses Count to get the number of odd numbers in the array
            ////int[] Arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            ////var res=Arr1.Where(i => i%2 != 0).Count();
            ////Console.WriteLine(res);

            ////2. Return a list of customers and how many orders each has.
            ////var res1 = CustomerList.Select(c => new
            ////{
            ////    Name = c.CustomerName,
            ////    OrderCount = c.Orders.Count()
            ////});

            ////foreach (var i in res1)
            ////{
            ////    Console.WriteLine(i);
            ////}

            ////3. Return a list of categories and how many products each has
            ////var res2 = ProductList.GroupBy(p=> p.Category).Select(p => new
            ////{
            ////    Name = p.Key,
            ////    ProductCount = p.Count()
            ////});

            ////foreach (var i in res2)
            ////{
            ////    Console.WriteLine(i);
            ////}
            ////var res3 = ProductList.Select(p => p.Category).Distinct().Count();
            ////Console.WriteLine(res3);

            //////4. Get the total of the numbers in an array.
            ////int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            ////var res4 = Arr2.Sum();
            ////Console.WriteLine(res4);

            //5. Get the total number of characters of all words in dictionary_english.txt
            //(Read dictionary_english.txt into Array of String First).

            //String[] words = File.ReadAllLines("dictionary_english.txt");
            ////var res5= words.Sum(w=> w.Length);
            ////Console.WriteLine(res5);

            ////6. Get the length of the shortest word in dictionary_english.txt
            ////(Read dictionary_english.txt into Array of String First).

            //var res6 = words.Min(w => w.Length);
            //Console.WriteLine(res6);

            ////7.Get the length of the longest word in dictionary_english.txt(Read dictionary_english.txt
            ////    into Array of String First).
            //var res7 = words.Max(w => w.Length);
            //Console.WriteLine(res7);

            ////8.Get the average length of the words in dictionary_english.txt(Read dictionary_english.txt into 
            ////    Array of String First).
            //var res8 = words.Average(w => w.Length);
            //Console.WriteLine(res8);

            ////9.Get the total units in stock for each product category.
            //var res9 = ProductList.GroupBy(p => p.Category).Select(p => new {
            //    name = p.Key,
            //    totalUnits = p.Sum(x => x.UnitsInStock) 
            //});

            //foreach (var item in res9)
            //{
            //    Console.WriteLine(item);
            //}


            //10.Get the cheapest price among each category's products
            //var res10 = ProductList.GroupBy(p => p.Category).Select(p => new
            //{
            //    name = p.Key,
            //    minprice = p.Min(p => p.UnitPrice)
            //});

            //foreach (var item in res10)
            //{
            //    Console.WriteLine(item);
            //}

            //11. Get the products with the cheapest price in each category (Use Let)
            //var res11 =
            //             from p in ProductList
            //             group p by p.Category into g
            //             let minPrice = g.Min(x => x.UnitPrice)
            //             from p in g
            //             where p.UnitPrice == minPrice
            //             select new
            //             {
            //                 Category = g.Key,
            //                 ProductName = p.ProductName,
            //                 Price = p.UnitPrice
            //             };

            //foreach (var item in res11)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Product: {item.ProductName}, Price: {item.Price}");
            //}

            //12. Get the most expensive price among each category's products.
            //var res12 = ProductList.GroupBy(p => p.Category).Select(p => new
            //{
            //    name = p.Key,
            //    minprice = p.Max(p => p.UnitPrice)
            //});

            //foreach (var item in res12)
            //{
            //    Console.WriteLine(item);
            //}

            //13. Get the products with the most expensive price in each category.
            //var res13 = ProductList.GroupBy(p => p.Category).Select(p => new
            //{
            //    name = p.Key,
            //    Products = p.Where(x => x.UnitPrice == p.Max(y => y.UnitPrice))
            //});

            //foreach (var item in res13)
            //{
            //    Console.WriteLine($"Category: {item.name}");

            //    foreach (var prod in item.Products)
            //    {
            //        Console.WriteLine($"   {prod.ProductName} - {prod.UnitPrice}");
            //    }
            //}

            //14. Get the average price of each category's products.
            //var res14 = ProductList.GroupBy(p => p.Category).Select(p => new
            //{
            //    name = p.Key,
            //    minprice = p.Average(p => p.UnitPrice)
            //});

            //foreach (var item in res14)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region LINQ - Ordering Operators
            //1. Sort a list of products by name
            //var r = ProductList.OrderBy(p=> p.ProductName);
            //foreach (var item in r)
            //{
            //    Console.WriteLine(item);
            //}

            //2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //String[] Arr3 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var r1 = Arr3.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var w in r1)
            //{
            //    Console.WriteLine(w);
            //} 

            //3. Sort a list of products by units in stock from highest to lowest.
            //var r3 = ProductList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in r3)
            //{
            //    Console.WriteLine(item);
            //}

            //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr4 = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var r4=Arr4.OrderBy(x=> x.Length ).ThenBy(x=> x);
            //foreach (var x in r4)
            //{
            //    Console.WriteLine(x);
            //}

            //5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //String[] Arr5 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var r5 = Arr5.OrderBy(x => x.Length).ThenBy(x => x, StringComparer.OrdinalIgnoreCase);
            //foreach (var x in r5)
            //{
            //    Console.WriteLine(x);
            //}

            //6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var r5 = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var item in r5)
            //{
            //    Console.WriteLine(item);
            //} 

            //7.Sort first by-word length and then by a case -insensitive descending sort of the words in an array.
            // String[] Arr7 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var r7 = Arr7.OrderBy(w=> w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var w in r7)
            //{
            //    Console.WriteLine(w);
            //}

            //8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr8 = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var list =Arr8.Where(x=> x.Length > 1 && x[1]=='i' ).Reverse();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Transformation Operators
            //1. Return a sequence of just the names of a list of products.
            //var re1=ProductList.Select(p => p.ProductName);
            //foreach (var p in re1)
            //{
            //    Console.WriteLine(p);
            //}

            //2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var list1= words.Select(x => new {upper=x.ToUpper(),lower= x.ToLower()});

            //foreach (var x in list1)
            //{
            //    Console.WriteLine(x);
            //}

            //3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var list2 = ProductList.Select(p => new
            //{
            //    productname=p.ProductName,
            //    unitsinstock=p.UnitsInStock,
            //    Price=p.UnitPrice
            //});

            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

           // 4.Determine if the value of int in an array matches their position in the array.
           //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

           // var result = Arr
           //     .Select((value, index) => new { value, matches = value == index });

           // foreach (var item in result)
           // {
           //     Console.WriteLine($"  \"{item.value}\": {item.matches.ToString().ToLower()},");
           // }

            //5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var res = numbersA
            //        .SelectMany(a => numbersB, (a, b) => new { a, b })  
            //        .Where(pair => pair.a < pair.b);                     

            //foreach (var pair in res)
            //{
            //    Console.WriteLine($"({pair.a}, {pair.b})");
            //}

            //6
            var smallOrders = CustomerList
                 .SelectMany(c => c.Orders)           
                 .Where(o => o.Total < 500);   

            foreach (var order in smallOrders)
            {
                Console.WriteLine($"OrderID: {order.OrderID}, CustomerID: , Total: {order.Total}");
            }
            //7
            var recentOrders = CustomerList
                        .SelectMany(c => c.Orders)               
                       .Where(o => o.OrderDate.Year >= 1998);   

            foreach (var order in recentOrders)
            {
                Console.WriteLine($"OrderID: {order.OrderID}, OrderDate: {order.OrderDate.ToShortDateString()}");
            }


            #endregion
        }
    }
}
