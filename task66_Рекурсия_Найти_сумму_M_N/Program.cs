/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();

System.Console.WriteLine("Введите число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int intN(int first, int last, int summ = 0)
{
        if (last >= first)
    {
        System.Console.Write(first + " ");
        summ += first;
        return intN(first + 1, last, summ);
    }
    else
        return summ;
}
int summ = intN(number1, number2);
System.Console.WriteLine("\nСумма равна: "+ summ);
