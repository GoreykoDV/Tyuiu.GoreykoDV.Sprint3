using Tyuiu.GoreykoDV.Sprint3.Task3.V5.Lib;

namespace Tyuiu.GoreykoDV.Sprint3.Task3.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #3 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                             *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #5                                                               *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Используя цикл foreach заменить буквы a  на * в строке: fifa al fall     *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string value = "fifa al fall";
            char replaceable = 'a';
            char replacement = '*';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Заменяемый символ = " + replaceable);
            Console.WriteLine("заменает = " + replacement);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Итог = " + ds.ReplaceCharInString(value, replaceable, replacement));

            Console.ReadKey();
        }
    }
}
