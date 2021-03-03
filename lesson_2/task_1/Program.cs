using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            name = name.Trim();

            Console.WriteLine("Enter age:");
            string age = Console.ReadLine();
            int age_int = int.Parse(age);
            if (age_int < 18)
                {
                Console.WriteLine("You should be minimum 18 years old to gamble");
            }
            else
            {
                Console.WriteLine("Place your bet:");
                string bet = Console.ReadLine();
                int bet_int = int.Parse(bet);
                if (bet_int < 5 || bet_int > 1000)
                {
                    Console.WriteLine("Invalid number");
                }
                else
                {

                }


            }
        }
    }
}
