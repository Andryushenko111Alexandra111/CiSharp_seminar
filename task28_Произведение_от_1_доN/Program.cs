/*
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
Произведение чисел это результат умножения этих чисел. Краткая запись суммы одинаковых слагаемых.
4 -> 24
5 -> 120
*/
 Console.Clear();

 int Num(int a)
 {
    int result = 1;
    for (int i = 1; i <= a; i++)
    {
        result = result * i;
    }
    return result;
 }
 System.Console.WriteLine("Введите число: ");
 int userNumber = Convert.ToInt32(Console.ReadLine());

 int userResult = Num(userNumber);
 Console.Clear();
 System.Console.WriteLine($"Произведение числа {userResult}");
