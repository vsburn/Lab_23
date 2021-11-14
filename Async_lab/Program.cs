using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Async_lab
{
    #region Задача
    /*
     * Разработать асинхронный метод для вычисления факториала числа. 
     * В методе Main выполнить проверку работы метода.
    */
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вычислить факториал числа: ");
            int f = Convert.ToInt32(Console.ReadLine());

            Task _ = FactorialAsync(f);

            Console.WriteLine("в Main высаживаем грядку:");
            for (int i = 0; i <= f; i++)
            {
                Console.WriteLine('°');
                Thread.Sleep(700);
            }

            Console.WriteLine("Main завершился");
            Console.ReadKey();
        }
        static async Task FactorialAsync(int num)
        {
            Console.WriteLine("Вычисляем факториал:");
            int res = await Task.Run(() =>
            {
                int result = 1;
                for (int i = 1; i <= num; i++)
                {
                    result *= i;
                    Console.WriteLine($"{result,10}");
                    Thread.Sleep(700);
                }
                return result;
            });
            Console.WriteLine($"Факториал вычислен: {res}");
        }

    }

}
