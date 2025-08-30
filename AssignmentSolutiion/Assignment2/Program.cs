using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using static Assignment2.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Set Operators
        
            //1. Find the unique Category names from Product List
            var result = ProductList.Select(p => p.Category).Distinct();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            //2. Produce a Sequence containing the unique first letter from both product
            //and customer names.
            var r1 = ProductList.Select(p => p.ProductName[0]);
            var r2 = CustomerList.Select(p => p.CustomerName[0]);

            var unique = r1.Union(r2);

            Console.WriteLine("unique");

            foreach (var item in unique)
            {

                Console.WriteLine(item);
            }

            //3. Create one sequence that contains the common first letter from both
            //product and customer names.
            
            var common = r1.Intersect(r2);

            Console.WriteLine("common");

            foreach (var item in common)
            {
                Console.WriteLine(item);
            }

            //4. Create one sequence that contains the first letters of product names
            //that are not also first letters of customer names

            var Except = r1.Except(r2);
            Console.WriteLine("Except");
                    foreach (var item in common)
                           {
                               Console.WriteLine(item);
                            }

            //5. Create one sequence that contains the last Three Characters in each name
            //of all customers and products, including any duplicates
            var r3 = ProductList.Select(p => p.ProductName.Length >= 3 ? p.ProductName[^3..] : p.ProductName);
            var r4 = CustomerList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName[^3..] : c.CustomerName);

            var Concat = r3.Concat(r4);
            
            foreach (var item in Concat)
            {
                Console.WriteLine(item);
            }



            #endregion


            #region Quantifiers
            //1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into
            //Array of String First) contain the substring 'ei'.

            string[] words = File.ReadAllLines("dictionary_english.txt");

            bool determine= words.Any(w=> w.Contains("ei"));

            Console.WriteLine(determine?"contain":"doesn't contain");

            //2. Return a grouped a list of products only for categories that have at least one product
            //that is out of stock.

            var res = ProductList.GroupBy(p => p.Category).Where(g => g.Any(p => p.UnitsInStock == 0)).Select(g => new
            {
                category = g.Key,
                Product = g.ToList()

            });
            foreach (var item in res)
            {
                Console.WriteLine($"category{item.category}");
                foreach (var item2 in item.Product)
                {
                    Console.WriteLine($"   Product: {item2.ProductName} - Units: {item2.UnitsInStock}");
                }
            }

            //3. Return a grouped a list of products only for categories that have all of their
            //products in stock.

            var res2 = ProductList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock > 0)).Select(g => new
            {
                category = g.Key,
                Product = g.ToList()

            });
            Console.WriteLine("------in stock-----");
            foreach (var item in res2)
            {
                Console.WriteLine($"category{item.category}");
                foreach (var item2 in item.Product)
                {
                    Console.WriteLine($"   Product: {item2.ProductName} - Units: {item2.UnitsInStock}");
                }
            }
            #endregion

            #region Grouping Operators
            //Use group by to partition a list of numbers by their remainder when divided by 5

            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var res3 = numbers.GroupBy(n=> n%5);

            foreach (var group in res3)
            {
                Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
                foreach (var num in group)
                {
                    Console.WriteLine($"   {num}");
                }
            }


            // Uses group by to partition a list of words by their first letter.
            //Use dictionary_english.txt for Input


            var groupwords = words.GroupBy(w => w[0]);

            Console.WriteLine("-------------------");
            foreach (var group in groupwords)
            {
                Console.WriteLine($"Words starting with '{group.Key}':");
                foreach (var word in group)
                {
                    Console.WriteLine($"   {word}");
                }
            }



            // Consider this Array as an Input Use Group By with a custom comparer that matches words that
            //  are consists of the same Characters Together

            String[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            var groups = Arr.GroupBy(
                  word => new string(word.OrderBy(c => c).ToArray()),  
                   new StringEqualityComparer() );

            foreach (var group in groups)
            {
                Console.WriteLine($"Group for '{group.Key}': {string.Join(", ", group)}");
            }
            #endregion

        }
    }
}
