/*
Напишите программу, которая будет выдавать название
 дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/

System.Console.WriteLine("Введите номер дня недели: ");

int day = Convert.ToInt32(Console.ReadLine());

if (day > 7)
{
   System.Console.WriteLine("Ведённое число слишком большое."); 
}
if (day < 1)
{
   System.Console.WriteLine("Ведённое число слишком маленькое."); 
}
if (day == 1)
{
   System.Console.WriteLine("Сегодня понедельник."); 
}
if (day == 2)
{
   System.Console.WriteLine("Сегодня вторник."); 
}
if (day == 3)
{
   System.Console.WriteLine("Сегодня среда."); 
}
if (day == 4)
{
   System.Console.WriteLine("Сегодня четверг."); 
}
if (day == 5)
{
   System.Console.WriteLine("Сегодня пятница."); 
}
if (day == 6)
{
   System.Console.WriteLine("Сегодня суббота."); 
}
if (day == 7)
{
   System.Console.WriteLine("Воскресенье. Сегодня выходной."); 
}