/*
45. Напишите программу, которая будет создавать 
копию заданного одномерного массива с помощью 
поэлементного копирования.
*/

Console.Clear();

int[] GetRandomArray(int start, int end, int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
}

int[] CopyArray(int[] arrayA)
{
    // поэлементное копирование массивов
    int n = arrayA.Length; // n - количество элементов массива

    int[] B = new int[n]; // массив-назначение

    // цикл копирования arrayA => B
    for (int i = 0; i < n; i++)
    {
        B[i] = arrayA[i];
    }
    return B;
}

int TakeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int userArraySize = TakeEntNum("Введите размер массива:");
int userArrayStart = TakeEntNum("Введите минимальное число массива:");
int userArrayEnd = TakeEntNum("Введите максимальное число массива:");
int[] userArray = GetRandomArray(userArrayStart, userArrayEnd, userArraySize);
PrintArray(userArray);
int[] copyArray = CopyArray(userArray);
PrintArray(copyArray);


// Console.Clear();

// int[] GetRandArray(int size, int start, int end)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(start, end + 1);
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i]);
//         if (i < arr.Length - 1)
//             System.Console.Write(", ");
//     }
//     System.Console.Write("]");
//     System.Console.Write(" ");
// }

// System.Console.Write("Ввести размер массива: ");
// int userSize = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Ввести диапазон массива от: ");
// int userStart = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Ввести диапазон массива до: ");
// int userEnd = Convert.ToInt32(Console.ReadLine());
// int[] userArray = GetRandArray(userSize, userStart, userEnd);
// PrintArray(userArray);

// Console.ForegroundColor = ConsoleColor.Green;
// System.Console.Write("-> ");

// int[] CopyArray(int[] array)
// {
//     Console.ForegroundColor = ConsoleColor.Blue;
//     int[] newArray = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         newArray[i] = array[i];
//     }
//     return newArray;
// }
// PrintArray(CopyArray(userArray));
