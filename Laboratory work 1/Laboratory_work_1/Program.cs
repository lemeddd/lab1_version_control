namespace Laboratory_work_1
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть число n для обчислення факторіалу: ");
            int n;
        
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n < 0)
                {
                    Console.WriteLine("Факторіал визначений лише для невід'ємних чисел.");
                }
                else
                {
                    long factorial = CalculateFactorial(n);
                    Console.WriteLine($"Факторіал числа {n} дорівнює {factorial}.");
                }
            }
            else
            {
                Console.WriteLine("Введено некоректне значення. Будь ласка, введіть ціле число.");
            }
        }

        static long CalculateFactorial(int number)
        {
            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}