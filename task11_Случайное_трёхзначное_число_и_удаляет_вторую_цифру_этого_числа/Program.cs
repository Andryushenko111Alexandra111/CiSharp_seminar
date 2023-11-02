/*11. Напишите программу, которая выводит случайное трёхзначное 
число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/
Console.Clear();

int number = new Random().Next(100,1000);
System.Console.WriteLine(number);

int first = number / 100;
System.Console.Write(first);

int second = number%10;
System.Console.WriteLine(second);
System.Console.WriteLine(first +""+second);
int result = first *10+second;
System.Console.WriteLine(result);