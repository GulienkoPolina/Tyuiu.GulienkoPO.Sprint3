using Tyuiu.GulienkoPO.Sprint3.Task7.V30.Lib;

namespace Tyuiu.GulienkoPO.Sprint3.Task7.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine(" Старт шага = " + startValue);
            Console.WriteLine(" Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(( startValue, valueArray[i]));
                startValue++;
            }

            Console.ReadKey();
        }
    }
}