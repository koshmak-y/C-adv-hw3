using System;

/* Задание
Используя Visual Studio, создайте проект по шаблону Console Application
Создайте программу в которой создайте класс делегат, который в качестве параметров
принимает три целочисленных аргумента и возвращает целочисленный тип. Далее создайте
анонимный метод, который также принимает три целочисленных аргумента и возвращает
среднее арифметическое этих аргументов. Сообщите данный анонимный метод с экземпляром
делегата, который был ранее создан.
 */

namespace hw1
{
    class Program
    {
        delegate int delegate1(int a, int b, int c);
        static void Main(string[] args)
        {

            delegate1 anonim = (a, b, c) => { return (a + b + c) / 3; };
            delegate1 MyDelegate = new delegate1(anonim);
            Console.WriteLine(MyDelegate.Invoke(3, 4, 5));
            Console.ReadKey();
        }
    }
}
