using Tyuiu.GulienkoPO.Sprint3.Task5.V26.Lib;

namespace Tyuiu.GulienkoPO.Sprint3.Task5.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 13;

            Console.WriteLine(" Переменная Х = " + x);
            Console.WriteLine(" Старт шага 1 = " + startValue1);
            Console.WriteLine(" Конец шага 1 = " + stopValue1);
            Console.WriteLine(" Старт шага 2 = " + startValue2);
            Console.WriteLine(" Конец шага 2 = " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2));

            Console.ReadKey();
        }
    }
}