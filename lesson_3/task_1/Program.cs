using System;

//8.Умножение числа а = 12345679 на числа 9, 18, 27, ... 81 дает интересные результаты. 
//Напишите программу получения этих произведений.
namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123456789;
            int b = 9;           
            for (int i = 1; i < 10; i++)
            {
                int c = b * i;
                Console.WriteLine(a * c);
            }
        }
    }
}
