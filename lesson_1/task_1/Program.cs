using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter adress:");
            string adress = Console.ReadLine();

            Console.WriteLine("Enter phone:");
            string phone = Console.ReadLine();

            Console.WriteLine("Enter height:");
            int height = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(adress);
            Console.WriteLine(phone);
            Console.WriteLine(height);

        }
    }
}
