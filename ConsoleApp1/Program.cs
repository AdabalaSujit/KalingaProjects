using ClassLibrary2;
using module_1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<documents> f = new List<documents>();
            List<folder> f1 = new List<folder>();
            Console.WriteLine("Hello World!");
            //for (int i = 0; i < 2; i++)
            //{
            //    documents n= new documents();

            //    n.id = Convert.ToInt32(Console.ReadLine());
            //    n.name = Console.ReadLine();
            //    f.Add(n);
            //}
            for (int i = 0; i < 2; i++)
            {
                folder n1 = new folder();

                n1.id = Convert.ToInt32(Console.ReadLine());
                n1.name = Console.ReadLine();
                f1.Add(n1);
            }

            var n2 = f1.Distinct(new BoxEqualityComparer());
            foreach (var r in n2)
            {
                Console.WriteLine(r.id);
            }
            Console.ReadLine();

        }
    }
}

