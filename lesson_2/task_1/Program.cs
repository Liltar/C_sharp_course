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
                    Random rnd = new Random();
                    int first = rnd.Next(1, 10);
                    int second = rnd.Next(1, 10);
                    int third = rnd.Next(1, 10);
                    double coef_static = 1.5;
                    double coef_static_2 = 1.25;
                    Console.WriteLine($"Your combination is {first}{second}{third}");
                    if (first == second && second == third)
                    {
                        if (first == 1)
                        {
                            double prize = coef_static * bet_int * 10;
                            Console.WriteLine($"You won {prize}");
                        }
                        else if (first == 2)
                        {
                            double prize = coef_static * bet_int * 20;
                            Console.WriteLine($"You won {prize}");
                        }
                        else if (first == 3)
                        {
                            double prize = coef_static * bet_int * 30;
                            Console.WriteLine($"You won {prize}");
                        }
                        else if (first == 4)
                        {
                            double prize = coef_static * bet_int * 40;
                            Console.WriteLine($"You won {prize}");
                        }
                        else if (first == 5)
                        {
                            double prize = coef_static * bet_int * 50;
                            Console.WriteLine($"You won {prize}");
                        }
                        else if (first == 6)
                        {
                            double prize = coef_static * bet_int * 60;
                            Console.WriteLine($"You won {prize}");
                        }
                        else if (first == 7)
                        {
                            double prize = coef_static * bet_int * 150;
                            Console.WriteLine($"You won {prize}");
                        }
                        else if (first == 8)
                        {
                            double prize = coef_static * bet_int * 80;
                            Console.WriteLine($"You won {prize}");
                        }
                        else if (first == 9)
                        {
                            double prize = coef_static * bet_int * 9.0;
                            Console.WriteLine($"You won {prize}");
                        }
                    }
                    else if (first == second)
                    {
                        if (first == 1)
                        {
                            double prize = coef_static_2 * bet_int * 1;
                            Console.WriteLine($"You won {prize}");
                        }
                        else if (first == 2)
                        {
                            double prize = coef_static_2 * bet_int * 2;
                            Console.WriteLine($"You won {prize}");
                        }
                        else if (first == 3)
                        {
                            double prize = coef_static_2 * bet_int * 3;
                            Console.WriteLine($"You won {prize}");
                        }
                        else if (first == 4)
                        {
                            double prize = coef_static_2 * bet_int * 4;
                            Console.WriteLine($"You won {prize}");
                        }
                        else if (first == 5)
                        {
                            double prize = coef_static_2 * bet_int * 5;
                            Console.WriteLine($"You won {prize}");
                        }
                        else if (first == 6)
                        {
                            double prize = coef_static_2 * bet_int * 6;
                            Console.WriteLine($"You won {prize}");
                        }
                        else if (first == 7)
                        {
                            double prize = coef_static_2 * bet_int * 15;
                            Console.WriteLine($"You won {prize}");
                        }
                        else if (first == 8)
                        {
                            double prize = coef_static_2 * bet_int * 8;
                            Console.WriteLine($"You won {prize}");
                        }
                        else if (first == 9)
                        {
                            double prize = coef_static_2 * bet_int * 9;
                            Console.WriteLine($"You won {prize}");
                        }
                    }
                    else if (first == 7 || second == 7 || third == 7)
                    {
                        double prize = 1.6 * bet_int;
                        Console.WriteLine($"You won {prize}");
                    }
                    else if (first == 9 || second == 9 || third == 9)
                    {
                        double prize = 1.35 * bet_int;
                        Console.WriteLine($"You won {prize}");
                    }
                    }
                }
            }
        }
    }