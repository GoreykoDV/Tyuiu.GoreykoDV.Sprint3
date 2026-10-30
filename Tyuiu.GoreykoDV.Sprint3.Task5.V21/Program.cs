using Tyuiu.GoreykoDV.Sprint3.Task5.V21.Lib;

namespace Tyuiu.GoreykoDV.Sprint3.Task5.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #3 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Вложенные циклы                                                    *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #21                                                              *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");


            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            Console.WriteLine("Старт шага 1 = " + startValue1);
            Console.WriteLine("конец шага 1 = " + stopValue1);
            Console.WriteLine("Старт шага 2 = " + startValue2);
            Console.WriteLine("конец шага 2 = " + stopValue2);


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

            Console.ReadKey();
        }
    }
}
