using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            name = name.Trim();

            Console.WriteLine("Enter age:");
            string age = Console.ReadLine();
            int age_int = int.Parse(age);

            Console.WriteLine("Enter adress:");
            string adress = Console.ReadLine();
            adress = adress.Trim();

            Console.WriteLine("Enter phone:");
            string phone = Console.ReadLine();
            phone = phone.Trim();

            Console.WriteLine("Enter height:");
            string height = Console.ReadLine();
            int height_int = int.Parse(height);
            

            Console.Clear();
            Console.WriteLine(name);
            Console.WriteLine(age_int);
            Console.WriteLine(adress);
            Console.WriteLine(phone);
            Console.WriteLine(height_int);

        }
    }
}
