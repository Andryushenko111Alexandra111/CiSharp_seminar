/*
Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
System.Console.WriteLine("Введите число: ");
string inputString = Console.ReadLine(); //ожидает ввод строки с консоли и присваивает inputString введённой строки
int number = Convert.ToInt32(inputString); // конвертирует из строки в число
if (number < 100)
{
    System.Console.WriteLine("третьей цифры нет");
}
else // иначе
{
    System.Console.WriteLine (inputString[2]); //вывод в конисоль третий символ строки по индексу [2]
}
