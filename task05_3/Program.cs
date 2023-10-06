/* 5. Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N. 

4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/

System.Console.Write("Введите число N: ");

int numberN = int.Parse(Console.ReadLine());

for (int i = numberN * -1; i < numberN + 1; i++)
{
System.Console.Write(i + " ");
}
