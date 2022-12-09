using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пользователь вводит число для проверки
            Console.WriteLine("Введите целое число: ");
            int value = int.Parse(Console.ReadLine());

            // Проверка числа с помощью деления с остатком
            int valueCheck = value % 2;

            if (valueCheck == 0)
            {
                Console.WriteLine("Данное число является чётным.");
                Console.WriteLine("Нажмите Enter для выхода.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Данное число является нечётным.");
                Console.WriteLine("Нажмите Enter для выхода.");
                Console.ReadLine();
            }

        }
    }
}
