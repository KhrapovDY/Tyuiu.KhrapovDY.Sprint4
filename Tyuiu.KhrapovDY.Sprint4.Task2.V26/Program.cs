using Tyuiu.KhrapovDY.Sprint4.Task2.V26.Lib;

namespace Tyuiu.KhrapovDY.Sprint4.Task2.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Храпов Д. Ю. | СМАРТб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                         *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                              *");
            Console.WriteLine("* Задание #2                                                                        *");
            Console.WriteLine("* Вариант #26                                                                       *");
            Console.WriteLine("* Выполнил: Храпов Даниил Юрьевич | СМАРТб-24-1                                     *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный случайными в      *");
            Console.WriteLine("* диапазоне от 1 до 8 подсчитать произведение нечетных элементов массива.           *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.Write("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++) 
            {
                numsArray[i] = rnd.Next(1, 8);
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1 ; i++) 
            {
                Console.WriteLine(numsArray[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Произведение элементов  = " + res);
            Console.ReadKey();

        }
    }
}
