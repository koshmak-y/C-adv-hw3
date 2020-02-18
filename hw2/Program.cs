using System;

/* Задание
Используя Visual Studio, создайте проект по шаблону Console Application
Создайте программу, в которой создайте четыре лямбда оператора для выполнения
арифметических действий, первый лямбда оператор для сложения, второй для вычитания,
третий для умножения и четвертый для деления (лямбда оператор для деления должен
выполнять проверку деления на ноль). Каждый лямбда оператор должен принимать два
аргумента и возвращать соответственный результат вычисления. В программе организуйте
логику, которая будет выполнять арифметическую операцию указанную пользователем.
 */

namespace hw2
{
    class Program
    {
        delegate double Operation(double value1, double value2);
        static void Main(string[] args)
        {
            Console.Write("Enter int value 1 : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter int value 2: ");
            double b = Convert.ToDouble(Console.ReadLine());
        onemore:
            Console.WriteLine("\nEnter number of operation:\n" +
                "1. Sum \n" +
                "2. Sub \n" +
                "3. Prod \n" +
                "4. Div \n" +
                "5. Exit"
                );
            Console.Write("Your choice: ");
            string number = Console.ReadLine();
            switch (number)
            {
                case "1": 
                    Operation sum = (a, b) => a + b;
                    Console.WriteLine("{0}+{1}={2}", a, b, sum.Invoke(a, b));
                    break;
                case "2":
                    Operation sub = (a, b) => a - b;
                    Console.WriteLine("{0}-{1}={2}", a, b, sub.Invoke(a, b));
                    break;
                case "3":
                    Operation prod = (a, b) => a * b;
                    Console.WriteLine("{0}*{1}={2}", a, b, prod.Invoke(a, b));
                    break;
                case "4":
                    {
                        try
                        {
                            Operation div = (a, b) => (a / b);
                            Console.WriteLine("{0}/{1}={2}", a, b, div.Invoke(a, b));
                        }
                        catch
                        {
                            Console.WriteLine("Error: Division by 0.");
                        }
                        break;
                    }
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Out of range");
                    break;
            }
            goto onemore;
        }
    }
}
