﻿/* Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
    System.Console.WriteLine("Введите трёхзначное число: ");//вывод в консоль(терминал)
    int number = Convert.ToInt32(Console.ReadLine()); //ожидается ввод данных в консоль и конвертирует из строки в целое число
    
    
    if (number < 100 || number >= 1000)//условие
    {
        System.Console.WriteLine("Вы ввели не трёхзначное число.");// вывод в консоль
    }
    else //относится к условию "иначе"
    {
        int first = number / 10; //делит число и откидывает значение после запятой

        int second = first % 10; //получает остаток от деления first на 10
        System.Console.WriteLine($"Второе число '{second}'"); // вывод данных в консоль
    }