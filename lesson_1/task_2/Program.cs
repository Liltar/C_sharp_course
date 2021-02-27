using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter product name:");
            string product_name = Console.ReadLine();
            product_name = product_name.Trim();
            product_name = product_name.ToUpper();

            Console.WriteLine("Enter product quantity:");


            Console.Clear();
            Console.WriteLine(product_name);
        }
    }
}
