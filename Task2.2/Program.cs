using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Здравствуйте, укажите количество карт у вас в руках:");
            int cardsAmount = int.Parse(Console.ReadLine());
            int sum = 0;

            Console.WriteLine("По очереди введите номинал каждой карты.(Возможные номиналы: 5, 6, 7, 8, 9, J, Q, K, T.)");
            Console.WriteLine();
            for (int counter = 0; counter < cardsAmount; counter++)
            {
                Console.WriteLine("Введите номинал карты, и нажмите Enter:");
                var cardValue = Console.ReadLine();
                bool cardCheck;
                if (cardValue == "J" || cardValue == "Q" || cardValue == "K" || cardValue == "T")
                {
                    cardCheck = true;
                }
                else
                {
                    cardCheck = false;
                }
                if (cardCheck == true)
                {
                    sum = sum += 10;
                }
                else if (cardCheck == false)
                {
                    sum = sum + int.Parse(cardValue);
                }
            }                
            Console.WriteLine($"Итоговая сумма карт: {sum}");
            Console.WriteLine("Нажмите Enter для выхода");
            Console.ReadLine();
        }
    }
}
