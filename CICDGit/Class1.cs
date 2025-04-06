using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICD
{

    public class Class1
    {
        //Факториал числа
        public static double Factorial(double x)
        {
            try
            {
                if (x < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(x), "Значение должно быть неотрицательным.");
                }

                if (x == 0 || x == 1)
                {
                    return 1;
                }

                return x * Factorial(x - 1);
            }
            catch (StackOverflowException)
            {
                Console.WriteLine("Ошибка: Переполнение стека при вычислении факториала.");
                throw;
            }
        }
        //Вычисление логорифма
        public static double LogOsn(int number, int osn)
        {
            if (number <= 0 || osn <= 0)
            {
                throw new ArgumentException("Числа должны быть больше нуля.");
            }

            if (osn == 1)
            {
                throw new ArgumentException("Основание логарифма не может быть равно единице.");
            }

            return Math.Log(number, osn);
        }
        //Вычисление корня
        public static double Koren(double number, double stepen)
        {
            if (number < 0 || stepen < 0)
            {
                throw new ArgumentException("Число должно быть неотрицательным.");
            }

            return Math.Pow(number, 1 / stepen);
        }
    }
}


