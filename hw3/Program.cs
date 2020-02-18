using System;

/* Задание
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте анонимный метод, который принимает
в качестве аргумента массив делегатов и возвращает среднее арифметическое
возвращаемых значений методов сообщенных с делегатами в массиве. Методы, 
сообщенные с делегатами из массива, возвращают случайное значение типа int.
*/

namespace hw3
{
    class Program
    {
        
        public delegate int Anonim(delegate1[] array);
        public delegate int delegate1();
        static void Main(string[] args)
        {
            delegate1 delegate1 = new delegate1(random);
            delegate1 delegate2 = new delegate1(random);

            delegate1[] array = { delegate1, delegate2 };

            Anonim anonim = (array) =>
            {
                int count = 0;
                int sum = 0;
                foreach (delegate1 item in array)
                {
                    sum += item.Invoke();
                    count++;
                }
                return sum / count;
            };

            Console.WriteLine(anonim.Invoke(array));
        }

        static int random()
        {
            Random random = new Random();
            return random.Next(1, 100);
        }
    }
}
