/*
Задача 64: Задайте значение N. Напишите программу,
 которая выведет все натуральные числа в промежутке от N до 1. 
 Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.Clear();

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void intN(int number, int current = 0)
{    
    System.Console.WriteLine($"{number}, {current};");
    if (number < current+1) return;
    else
    {
    System.Console.Write((number-current) + " ");
    intN(number, current + 1);
    }
}

intN(number);

