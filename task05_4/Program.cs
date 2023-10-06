/* 5. Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N. 

4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/

System.Console.Write("Введите число N: ");

if(int.TryParse(Console.ReadLine(), out int numberN))
{
    for (int i = numberN * (-1); i < numberN + 1; i++)
    {
        if(i == numberN)
        {
            System.Console.Write(i);
        }
        else
        {
            System.Console.Write(i + ", ");
        }
    }
}
else 
{
    System.Console.WriteLine("Ошибка.Введено не целое число или не число.");
}