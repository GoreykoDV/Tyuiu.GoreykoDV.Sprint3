using Tyuiu.GoreykoDV.Sprint3.Task0.V3.Lib;

namespace Tyuiu.GoreykoDV.Sprint3.Task0.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            
            Console.Title = "Спринт #3 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Оператор цикла for                                                 *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #3                                                               *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу используя цикл for,                                   *");
            Console.WriteLine("* которая вычисляет сумму ряда по формуле                                  *");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую последовательность:*");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int startValue = 1;
            int stopValue = 10;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("конец шага = " + stopValue);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Сумма = " + ds.GetSumSeries(startValue, stopValue));
            

            
        }
    }
}
