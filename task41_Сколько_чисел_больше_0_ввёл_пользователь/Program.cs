/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();



int TakeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int userArraySize = TakeEntNum("Введите количество задаваемых чисел:");

int[] userArray = new int [userArraySize];

for (int i = 0; i < userArraySize; i++)
{
   userArray[i] = TakeEntNum("Введите число:"); 
}

int GetCount(int[] arr)
{
    int count =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0)
        count++;  
    }
    return count;
}


int count = GetCount (userArray);
System.Console.WriteLine(count);

// int[] GetArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// void PrintArray(int[] arr)
// {
//     Console.ForegroundColor = ConsoleColor.Green;
//     System.Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.ForegroundColor = ConsoleColor.Cyan;
//         Thread.Sleep(1);
//         System.Console.Write(arr[i]);
//         if (i < arr.Length - 1)
//             System.Console.Write(", ");
//     }
//     Console.ForegroundColor = ConsoleColor.Green;
//     System.Console.WriteLine("]");
//     Console.ResetColor();
// }

// int userSize = Prompt("Enter array size: ");
// int[] userArray = GetArray(userSize);
// PrintArray(userArray);

// int CountPositivDigits(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) result ++;
//     }
//     return result;
// }
// int count = CountPositivDigits(userArray);
// System.Console.WriteLine();
// System.Console.WriteLine($"Positive Digits > 0 = {count}");

