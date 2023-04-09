using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace циклы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип прогрессии: 1 - арифметическая, 2 - геометрическая");
            int type = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите первый член прогрессии");
            double first = double.Parse(Console.ReadLine());

            if (type == 1)
            {
                Console.WriteLine("Введите разность прогрессии");
                double diff = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите номер последнего члена");
                int last = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите способ решения: 1 - циклы, 2 - формулы");
                int method = int.Parse(Console.ReadLine());

                if (method == 1)
                {
                    double sum = 0;
                    for (int i = 0; i < last; i++)
                    {
                        double term = first + i * diff;
                        sum += term;
                    }
                    Console.WriteLine($"Сумма арифметической прогрессии: {sum}");
                }
                else if (method == 2)
                {
                    double sum = (2 * first + (last - 1) * diff) * last / 2;
                    Console.WriteLine($"Сумма арифметической прогрессии: {sum}");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
            else if (type == 2)
            {
                Console.WriteLine("Введите знаменатель прогрессии");
                double ratio = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите номер последнего члена");
                int last = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите способ решения: 1 - циклы, 2 - формулы");
                int method = int.Parse(Console.ReadLine());

                if (method == 1)
                {
                    double sum = 0;
                    for (int i = 0; i < last; i++)
                    {
                        double term = first * Math.Pow(ratio, i);
                        sum += term;
                    }
                    Console.WriteLine($"Сумма геометрической прогрессии: {sum}");
                }
                else if (method == 2)
                {
                    double sum = first * (1 - Math.Pow(ratio, last)) / (1 - ratio);
                    Console.WriteLine($"Сумма геометрической прогрессии: {sum}");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }
}
