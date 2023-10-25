/*
44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1 
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Write("Введите количество чисел Фибоначчи: ");
int N = int.Parse(Console.ReadLine());

if (N < 1)
{
    Console.WriteLine("Пожалуйста, введите положительное число.");
    return;
}

int first = 0;
int second = 1;

Console.Write("Первые " + N + " чисел Фибоначчи: ");

if (N >= 1)
{
    Console.Write(first);
}

if (N >= 2)
{
    Console.Write(", " + second);
}

for (int i = 3; i <= N; i++)
{
    int next = first + second;
    Console.Write(", " + next);
    first = second;
    second = next;
}

Console.WriteLine();

// public class Program044
// {
//     public static void Main(string[] args)
//     {
//         int N = 7;
//         FibonacciNumbers(N);
//     }
//     private static void FibonacciNumbers(int number)
//     {
//         int[] arr = new int[number];
//         int firstElement = 0;
//         int secondElement = 1;
//         for (int i = 0; i < number; i++)
//         {
//             if (i < 2)
//             {
//                 arr[i] = i;
//             }
//             else
//             {

//                 arr[i] = arr[firstElement] + arr[secondElemet];
//                 firstElement++;
//                 secondElemet++;
//             }

//             System.Console.Write($"{arr[i]} ");


//         }

//     }
// }

