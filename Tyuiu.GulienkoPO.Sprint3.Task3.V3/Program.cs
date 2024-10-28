using Tyuiu.GulienkoPO.Sprint3.Task3.V3.Lib;

namespace Tyuiu.GulienkoPO.Sprint3.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "cvbmzff orffgtrr dkfvfffdr";
            char chr = 'f';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Исходный символ = " + chr);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Минимальное количество символов = " + ds.GetMinCharCount(value, chr));

            Console.ReadKey();
        }
    }
}