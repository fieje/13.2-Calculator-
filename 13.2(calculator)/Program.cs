//Калькулятор
using System;

class Program
{
    static void Main(string[] args)
    {
        float num1, num2;
        char oper;

        Console.WriteLine("Enter operator (+, -, *, /): ");
        oper = char.Parse(Console.ReadLine());

        Console.WriteLine("Enter two numbers: ");
        num1 = float.Parse(Console.ReadLine());
        num2 = float.Parse(Console.ReadLine());

        switch (oper)
        {
            case '+':
                Console.WriteLine("Result: " + (num1 + num2));
                break;
            case '-':
                Console.WriteLine("Result: " + (num1 - num2));
                break;
            case '*':
                Console.WriteLine("Result: " + (num1 * num2));
                break;
            case '/':
                if (num2 != 0)
                {
                    Console.WriteLine("Result: " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("Error: Division by zero.");
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operator.");
                break;
        }
        Console.ReadLine();
    }
}
