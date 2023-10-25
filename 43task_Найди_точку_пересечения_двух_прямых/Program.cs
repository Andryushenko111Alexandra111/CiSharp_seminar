/*
Задача 43: Напишите программу, которая найдёт 
точку пересечения двух прямых, заданных уравнениями
 y = k1 * x + b1, y = k2 * x + b2; значения b1, k1,
  b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();

// double GetX(int b1, int k1, int b2, int k2)
// {
//     return (double) (b2-b1)/(k1-k2);
// }
// double GetY(int b1, int k1, double x)
// {
//     return (double) (k1*x)+b1;
// }

// int TakeEntNum(string message)
// {
//     System.Console.WriteLine(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int b1 = TakeEntNum("Введите целое число b1:");
// int k1 = TakeEntNum("Введите целое число k1:");
// int b2 = TakeEntNum("Введите целое число b2:");
// int k2 = TakeEntNum("Введите целое число k2:");


// double x = GetX (b1,k1,b2,k2);
// double y = GetY (b1,k1, x);
// System.Console.WriteLine($"({x}; {y})");


Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

void CrossLine(double b1, double k1, double b2, double k2)
{

    if (k1 == k2)
    {
        if (b1 == b2)
            System.Console.WriteLine("Прямые совпадают");
        else
            System.Console.WriteLine("Прямые параллельны");
            return;
    }
    double x = Math.Round(((-b2 + b1) / (-k1 + k2)),2);
    double y = Math.Round((k2 * x + b2),2);
    Console.WriteLine($"Две прямые пересекаются в точке с координатами ({x}; {y})");
}
CrossLine(b1, k1, b2, k2);
