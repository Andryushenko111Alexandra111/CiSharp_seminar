void Print2DArray(int[,] array)
{
    System.Console.Write($"[ ]\t");
    int start = 0;
    for (int i = start; i < start + array.GetLength(1); i++)
    {
        System.Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"["+ i +"]\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
        System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
