using static LINQ.ListGenerators;
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators
            #region Q1
            //var result = ProductList.First(p => p.UnitsInStock == 0);
            //Console.WriteLine(result); 
            #endregion
            #region Q2
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice>1000);
            //Console.WriteLine(result);
            #endregion
            #region Q3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(p => p > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(result);

            #endregion
            #endregion
            #region LINQ - Aggregate Operators
            #region Q1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(p => p % 2 == 1).Count();
            //Console.WriteLine(result);
            #endregion
            #region Q2
            //var result = CustomerList.Select(c => new {c.CustomerName,OrderCount=c.Orders.Count()}).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q3
            //var items = ProductList.GroupBy(c => c.Category).Select(c => new {c.Key,counter=c.Count()}).ToList();
            //foreach (var item in items)
            //{ Console.WriteLine(item); } 
            #endregion
            #region Q4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=Arr.Sum(x => x);
            //Console.WriteLine(result);
            #endregion
            #endregion
        }
    }
}
