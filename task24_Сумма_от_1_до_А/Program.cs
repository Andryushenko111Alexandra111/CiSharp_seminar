/*
Напишите программу, которая на вход принимает число (А) и 
на выходе выдаёт сумму чисел от 1 до А
7 -> 28
4 -> 10
8 ->36
*/

Console.Clear();

System.Console.WriteLine("Введите число А: ");
int userA = Convert.ToInt32(Console.ReadLine());

int Summer(int a)
{
    int summ = 0;
    for (int i = 1; i <= a; i++)
    {
        summ = summ + i;
    }
    return summ;
}
int userResult = Summer(userA);
System.Console.WriteLine(userResult);