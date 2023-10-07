/* Внутри класса Answer напишите метод CompareNumbers,
 который на вход принимает два числа и выводит, какое 
 число большее, а какое меньшее.
 a = 5; b = 7 -> Первое число 5 меньше чем второе число 7

 a = 2; b = 2 -> Введенные числа равны 2

 a = -3; b = -9 -> Первое число -3 больше чем второе число -9

*/

using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        if (firstNumber == secondNumber)
        {
            Console.WriteLine($"Введенные числа равны `{firstNumber}`");
        }
        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
        }
        if (firstNumber < secondNumber)
        {
            Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
        }
    }

    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
            firstNumber = 5;
            secondNumber = 5;
        }

        CompareNumbers(firstNumber, secondNumber);
    }
}