using Tyuiu.KhrapovDY.Sprint4.Task6.V15.Lib;

namespace Tyuiu.KhrapovDY.Sprint4.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Храпов Д. Ю. | СМАРТб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                         *");
            Console.WriteLine("* Тема: Класс Array                                                                 *");
            Console.WriteLine("* Задание #6                                                                        *");
            Console.WriteLine("* Вариант #15                                                                       *");
            Console.WriteLine("* Выполнил: Храпов Даниил Юрьевич | СМАРТб-24-1                                     *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Дан строковый массив данных [Чикаго, Хьюстон, Феникс, Филадельфия, Сан-Антонио,   *");
            Console.WriteLine("* Сан-Диего, Даллас] используя класс Array подсчитайте количество элементов, длина  *");
            Console.WriteLine("* которых меньше 7.                                                                 *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            var city = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };
            int res = ds.Calculate(city);

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= city.Length - 1; i++)
            {
                Console.WriteLine(city[i]);
            }

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("Количество элементов длинна которых = " + res);

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
