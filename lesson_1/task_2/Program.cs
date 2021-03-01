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
            var product_quantity_str = Console.ReadLine();
            product_quantity_str = product_quantity_str.Replace('.', ',');
            double product_quantity = Convert.ToDouble(product_quantity_str);

            Console.WriteLine("Enter unit of measurement:");
            string unit_of_measure = Console.ReadLine();
            unit_of_measure = unit_of_measure.ToLower();

            Console.WriteLine("Enter product price:");
            var product_price_str = Console.ReadLine();
            product_price_str = product_price_str.Replace('.', ',');
            double product_price = Convert.ToDouble(product_price_str);

            Console.Clear();
            Console.WriteLine(product_name);
            Console.WriteLine(product_quantity);
            Console.WriteLine(unit_of_measure);
            Console.WriteLine(product_price);
        }
    }
}
