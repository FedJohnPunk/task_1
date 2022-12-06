using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string fullName = "Иван Дмитриевич"; //Ф.И.О.
            string email = "ivan.fedyun@gmail.com"; //Электронная почта
            byte age = 17; //Возраст
            int physics = 85; //Баллы по физике
            int math = 76; //Баллы по математике
            int programming = 97; //Баллы по програмированию

            //Неудобный вариант
            //string output = $"Ф.И.О.: {fullName} \nВозраст: {age} \nEmail: {email} \nБаллы по физике: {physics} \nБаллы по математике: {math} \nБаллы по програмированию: {programming}";
            //Console.WriteLine(output);
            //Console.ReadKey();

            Console.WriteLine($"Ф.И.О.: {fullName}");
            Console.WriteLine($"Email: {email}");   
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Баллы по физике: {physics}");
            Console.WriteLine($"Баллы по математике: {math}");
            Console.WriteLine($"Баллы по програмированию^ {programming}");
            Console.ReadKey();

            int sum; //Сумма баллов по всем предметам
            sum = physics + math + programming;
            Console.WriteLine($"\nСумма баллов: {sum}");

            double average; //Средний балл
            average = (physics + math + programming)/ 3;
            Console.WriteLine($"Средний балл: {average}");
            Console.ReadLine();
             
        }
    }
}
