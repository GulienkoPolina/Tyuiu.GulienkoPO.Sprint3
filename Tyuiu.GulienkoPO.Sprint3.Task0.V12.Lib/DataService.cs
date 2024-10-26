using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GulienkoPO.Sprint3.Task0.V12.Lib
{
    public class DataService : ISprint3Task0V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                p *= (Math.Pow(value, i) + (Convert.ToDouble(1) / (i + 1)));
            }
            return Math.Round(p, 3);
        }
    }
}