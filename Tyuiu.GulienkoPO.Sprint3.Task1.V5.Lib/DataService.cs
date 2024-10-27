using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GulienkoPO.Sprint3.Task1.V5.Lib
{
    public class DataService : ISprint3Task1V5
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double MultSeries = 1.0;
            while (startValue < stopValue)
            {
                MultSeries = MultSeries * (Math.Cos(0.1) + Math.Pow(startValue, -2));
                startValue++;
            }
            return Math.Round(MultSeries, 3);

        }
    }
}
