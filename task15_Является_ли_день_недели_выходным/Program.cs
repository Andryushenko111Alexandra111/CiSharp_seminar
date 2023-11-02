/*
Напишите программу, которая принимает на 
вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
int Prompt(string message) //создали функцию (тип название)
{
   System.Console.WriteLine(message);
   string inputString = Console.ReadLine();//ожидание ввода строки и присваивание её значения
   int number = Convert.ToInt32(inputString);
   return number;// возврат числа и выход из функции
}

int day = Prompt("Введите номер дня недели: ");// объявление переменной day, присваеваем результат вызова функции Prompt

if (day > 7)
{
   System.Console.WriteLine("Такого дня недели нет.");
}
else
{
   if (day < 6)
   {
      System.Console.WriteLine("нет");
   }
   else
   {
      System.Console.WriteLine("да");
   }
}