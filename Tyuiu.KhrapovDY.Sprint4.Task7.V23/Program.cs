using Tyuiu.KhrapovDY.Sprint4.Task7.V23.Lib;

namespace Tyuiu.KhrapovDY.Sprint4.Task7.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int m = 3;
            int[,] mtrx = new int[n, m];

            string value = "678135972584";

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Храпов Д. Ю. | СМАРТб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                         *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                                       *");
            Console.WriteLine("* Задание #7                                                                        *");
            Console.WriteLine("* Вариант #23                                                                       *");
            Console.WriteLine("* Выполнил: Храпов Даниил Юрьевич | СМАРТб-24-1                                     *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"678135972584\". Преобразуйте ее в матрицу     *");
            Console.WriteLine("* 4 на 3 и подсчитайте количество четных чисел.                                     *");
           
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            int index = 0;

            Console.WriteLine("\nМассива:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{value[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            int res = ds.Calculate(n, m, value);

            Console.WriteLine("Количество четных чисел = " + res);
            Console.ReadKey();

        }
    }
}
