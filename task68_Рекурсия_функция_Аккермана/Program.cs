﻿/*
Задача 68: Напишите программу вычисления 
функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
Console.Clear();

System.Console.WriteLine("Введите число: m ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень: n");
int number2 = Convert.ToInt32(Console.ReadLine());

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}
int functionAkkerman = Ack(number1, number2);
Console.Write($"Функция Аккермана = {functionAkkerman} ");