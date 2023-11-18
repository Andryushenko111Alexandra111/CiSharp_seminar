/* Внутри класса Answer напишите метод DistanceBetweenPoints, 
который принимает на вход координаты двух точек pointA и pointB в 
виде массива целых чисел, и возвращает расстояние между ними
 в 3D пространстве.
 A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
System.Console.WriteLine("Enter number: ");
int N = Convert.ToInt32(Console.ReadLine());
int revN = 0;
for (int i = N; i > 0; i /= 10)
{
    revN = revN * 10 + i % 10;
    //System.Console.WriteLine(revN);
}
if (N == revN)
    System.Console.WriteLine("Yes");
else System.Console.WriteLine("No");
System.Console.Write("Введите координаты x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
/*
double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
Console.Write(d);
*/
//double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
//Console.Write(Math.Round(d, 2));

double squareX = Math.Pow(pointB[0] - pointA[0], 2);
double squareY = Math.Pow(pointB[1] - pointA[1], 2);
double squareZ = Math.Pow(pointB[2] - pointA[2], 2);
double result = Math.Sqrt(squareX + squareY + squareZ);
return result;
