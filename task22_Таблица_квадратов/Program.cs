/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console. Clear();
void TableSquare(int n)
{
   for (int i = 1; i < n+1; i++)
   {
      System.Console.WriteLine(Math.Pow(i,2));
   }
}

System.Console.WriteLine("Введи число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
TableSquare(numberN);

//int userNumber = int.Parse(Console.ReadLine());

// for (int i = 1; i <= userNumber; i++)
// {
//    System.Console.WriteLine($"{i} * {i} = {Math.Pow(i,2)}");
// }
