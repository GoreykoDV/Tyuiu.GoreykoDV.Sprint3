using Tyuiu.GoreykoDV.Sprint3.Task4.V29.Lib;

namespace Tyuiu.GoreykoDV.Sprint3.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #3 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                 *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #29                                                              *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5                          *");
            Console.WriteLine("* вычислить значение функции y=cos(x)/x                                    *");
            Console.WriteLine("* При х = 0 пропустить значение. Полученные значения суммировать.          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("конец шага = " + stopValue);


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.Calculate(startValue, stopValue));

            Console.ReadKey();
        }
    }
}
