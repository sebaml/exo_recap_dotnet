using System;
using System.Linq;

namespace DataLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ContosoContext())
            {
                var temp = context.Products.ToList();
                temp = temp.Where(p => p.UnitsInStock == 0).ToList();
                foreach (var t in temp)
                    Console.WriteLine(t);

                Console.WriteLine("BREAK !");
                temp = temp.Where(p => p.UnitPrice > 25).ToList();
                foreach (var t in temp)
                    Console.WriteLine(t);
                Console.WriteLine(temp);
            }
        }
    }
}