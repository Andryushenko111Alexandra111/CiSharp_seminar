/*
Напишите программу, которая принимает два числа 
 проверяет, является ли первое число квадратом второго
*/

System.Console.WriteLine("Введите первое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
int sqNumbers2 = userNumber1 * userNumber2;
bool result = userNumber1 == sqNumbers2;
Console.WriteLine(result);