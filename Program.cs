using static LINQ.ListGenerator;
namespace LINQ

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            #region Point 1
            //var outStock = ProductsList.Where(P => P.UnitsInStock == 0);
            //foreach(var o in outStock)
            //{
            //    Console.WriteLine(o);
            //}
            #endregion
            #region Point 2
            //var inStock = ProductsList.Where(p => p.UnitPrice > 3 );
            //foreach (var product in inStock)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region Point 3
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    if (Arr[i].Length < i){
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #endregion
            #region Q2
            #region First Point
            //var sortarray = ProductsList.OrderBy(p => p.ProductName);
            //foreach (var sort in sortarray)
            //{
            //    Console.WriteLine(sort);
            //}
            #endregion
            #region Second Point
            // string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Arr[i]=Arr[i].ToLower();
            //}
            //Array.Sort(Arr);
            //foreach (var str in Arr)
            //{
            //    Console.WriteLine(str);
            //}
            #endregion
            #endregion
            #region Q3
            #region FirstPoint
            //var Highest = ProductsList.OrderByDescending(p => p.UnitsInStock);
            //foreach(var high in Highest)
            //{
            //    Console.WriteLine(high);
            //}
            #endregion
            #region Second Point
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var array=Arr.OrderBy(a=>a.Length).ThenBy(a=>a).ToArray();
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region ThirdPoint
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Items=words
            //    .OrderBy(word => word.Length)
            //    .ThenBy(word => word,StringComparer.OrdinalIgnoreCase)
            //    .ToList();
            //foreach (var item in Items)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

        }

    }
}
