/* 
Напишите программу, которая выводит массив из 8 элементов,
 заплненный нулями и единицами в случайном порядке
*/
using System; // это библиотека функций
Console.Clear();

int[] GetRandArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    System.Console.Write("]");
}
Console.WriteLine("Задайте размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetRandArray(userSize);
PrintArray(userArray);
// Console.Write(string.Join(", ", userArray));