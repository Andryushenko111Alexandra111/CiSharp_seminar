/*Внутри класса Answer напишите метод CheckIfEven,
 который на вход принимает число number и выводит,
  является ли число чётным (делится ли оно на два без остатка).
*/

using System;

class Answer {
    static void CheckIfEven(int number)
    {
      int rest = number%2;
      if (rest == 0)
       System.Console.WriteLine($"Число {number} чётное");
      else 
      System.Console.WriteLine($"Число {number} нечётное");
    }
  
  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 9;
        }

        // Не удаляйте строки ниже
        CheckIfEven(number);
    }
}

