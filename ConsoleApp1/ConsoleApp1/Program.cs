using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Input()
        {
            Console.WriteLine("Введите А");
            Data.mas[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите B");
            Data.mas[1] = int.Parse(Console.ReadLine());
        }
        static void Sum()
        {
            Data.mas[2] = Data.mas[0] + Data.mas[1];
            Console.WriteLine("Сумма А и Б = {0} ", Data.mas[2]);
        }
        static void Raznost(int choise)
        {
            if (choise == 1)
            {
                Data.mas[3] = Data.mas[0] - Data.mas[1];
                Console.WriteLine("А-Б = {0}",Data.mas[3]);
            }
            else if (choise == 2)
            {
                Data.mas[3] = Data.mas[1] - Data.mas[0];
                Console.WriteLine("Б-А = {0}", Data.mas[3]);
            }
        }
        static void Proizved()
        {
            Data.mas[4] = Data.mas[0] * Data.mas[1];
            Console.WriteLine("Произведение А и Б = {0}", Data.mas[4]);
        }
        static void Del(int choise)
        {
            if (choise == 1)
            {
                Data.mas[5] = Data.mas[0] / Data.mas[1];
                Console.WriteLine("А/Б = {0}",Data.mas[5]);
            }
            else if (choise == 2)
            {
                Data.mas[3] = Data.mas[1] / Data.mas[0];
                Console.WriteLine("Б/А = {0}",Data.mas[5]);
            }
        }
        static void Stepen()
        {
            Console.WriteLine("Выберите что возвести в степень и в какую ");
            Console.WriteLine("1. А");
            Console.WriteLine("2. Б");
            int choise = int.Parse(Console.ReadLine());
            Console.WriteLine("Впишите степень");
            int step = int.Parse(Console.ReadLine());
            double chislo = 0;
            switch (choise)
            {
                case 1:
                    chislo = Math.Pow(Data.mas[0], step);
                    Console.WriteLine("{0} в степени {1} равно {2}", Data.mas[0], step, chislo);
                    break;
                case 2:
                    chislo = Math.Pow(Data.mas[1], step);
                    Console.WriteLine("{0} в степени {1} равно {2}", Data.mas[1], step, chislo);
                    break;
            }
        }
        static void Main(string[] args)
        {
            Input();
            int choise = 0;
            do
            {
                Console.WriteLine("Программа реалезует режимы");
                Console.WriteLine("Выберите действие");
                Console.WriteLine("1. Сложение ");
                Console.WriteLine("2. Вычетание ");
                Console.WriteLine("3. Умножение ");
                Console.WriteLine("4. Деление ");
                Console.WriteLine("5. Возведение в степень ");
                Console.WriteLine("6. Выход ");
                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        Sum();
                        break;

                    case 2:
                        Console.WriteLine("1. А-Б");
                        Console.WriteLine("2. Б-А");
                        int choi = int.Parse(Console.ReadLine());
                        Raznost(choi);
                        break;

                    case 3:
                        Proizved();
                        break;

                    case 4:
                        Console.WriteLine("1. А/Б");
                        Console.WriteLine("2. Б/А");
                        int chois = int.Parse(Console.ReadLine());
                        Del(chois);
                        break;

                    case 5:
                        Stepen();
                        break;

                    default:
                        Console.WriteLine("Завершение работы");
                        break;
                }
            } while (choise != 6);
        } 
    }
}
         
 
