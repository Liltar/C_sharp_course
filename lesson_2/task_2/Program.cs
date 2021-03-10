﻿//10) Составить блок-схему алгоритма проверки знания даты начала второй мировой войны. В случае неправильного ответа
//пользователя, программа должна выводить правильный ответ. Ниже приведён возможный вид экрана во время выполнения
//такой программы (Данные, вводимые пользователем, выделены полужирным шрифтом).
//В каком году началась вторая мировая война?
//Введите число и нажмите <Enter>
//-> 1939


//Правильно.
//11) Напишите программу проверки знания истории архитектуры. Программа должна вывести вопрос и три варианта ответа.
//Пользователь должен выбрать правильный ответ и ввести его номер. Ниже приведён возможный вид экрана во время
//выполнения такой программы (Данные, вводимые пользователем, выделены полужирным шрифтом).
//Архитектор Исаакиевского собора:
//1.Доменико Трезини
//2.Огюст Монферран
//3.Карл Росси
//Введите номер правильного ответа и нажмите <Enter>
//-> 3
//Вы ошиблись. Архитектор Исаакиевского собора — Огюст Монферран.
//12) Напишите программу проверки знания истории архитектуры. Программа должна вывести вопрос и три варианта ответа.
//Пользователь должен выбрать правильный ответ и ввести его номер. Ниже приведён возможный вид экрана во время
//выполнения такой программы (Данные, вводимые пользователем, выделены полужирным шрифтом).
//Невский проспект получил свое название:
//1.По имени реки, на берегах которой расположен Санкт-Петербург
//2. По имени близлежащего монастыря Александро-Невской лавры
//3. В память о знаменитом полководце Александре Невском
//Введите номер правильного ответа и нажмите <Enter>
//-> 1
//Вы ошиблись.
//Правильный ответ: 2.


using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("В каком году началась вторая мировая война?");
            int answer = int.Parse(Console.ReadLine());
            if (answer != 1939)
            { Console.WriteLine("Неправильно, вторая мировая война началась в 1939"); }
            else
            { Console.WriteLine("Правильно!"); }

            Console.WriteLine("Архитектор Исаакиевского собора: " +
                "\n1. Доменико Трезини" +
                "\n2. Огюст Монферран" +
                "\n3.Карл Росси");
            Console.WriteLine("Введите номер правильного ответа и нажмите <Enter>");
            answer = int.Parse(Console.ReadLine());
            if (answer != 2)
            { Console.WriteLine("Вы ошиблись. Архитектор Исаакиевского собора — Огюст Монферран."); }
            else
            {
                Console.WriteLine("Правильно!");
            }

            Console.WriteLine("Невский проспект получил свое название:" +
                "\n1.По имени реки, на берегах которой расположен Санкт-Петербург" +
                "\n2. По имени близлежащего монастыря Александро-Невской лавры" +
                "\n3. В память о знаменитом полководце Александре Невском" +
                "\nВведите номер правильного ответа и нажмите <Enter>");
            answer = int.Parse(Console.ReadLine());
            if (answer != 2)
            {
                Console.WriteLine("Вы ошиблись. Правильный ответ: 2.");
            }
            else
            {
                Console.WriteLine("Верно!");
            }

            // 21) Составить блок-схему алгоритма, который запрашивает у пользователя номер 
            // дня недели и выводит одно из
            //сообщений: "Рабочий день", "Суббота" ИЛИ "Воскресенье".Ниже приведён возможный 
            //вид экрана во время работы программы.
            //Введите номер дня недели(число от 1 до 7)
            //-> 5
            //Это рабочий день
            Console.WriteLine("Введите номер дня недели(число от 1 до 7)");
            int day_number = int.Parse(Console.ReadLine());
            if (day_number > 7 || day_number <= 0)
            {
                throw new IndexOutOfRangeException("Недопустимое значение");
            }
            else if (day_number == 6)
            {
                Console.WriteLine("Суббота");
            }
            else if (day_number == 7)
            {
                Console.WriteLine("Воскресенье");
            }
            else Console.WriteLine("Рабочий день");        
        }
    }
}