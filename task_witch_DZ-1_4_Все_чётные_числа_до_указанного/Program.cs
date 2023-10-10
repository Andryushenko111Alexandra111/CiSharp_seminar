/* Внутри класса Answer напишите метод 
PrintEvenNumbers, которая на вход
 принимает число (number), а на выходе 
 выводит все чётные числа от 1 до number
  (включительно), разделеные знаком табуляции.
*/

using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      for (int i = 2; i <= number; i = i+2)
      {
        if(i == 2)
        {
            System.Console.Write(i);
        }
        else
        {
            System.Console.Write("\t" + i);
        }
      }


    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 5;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}