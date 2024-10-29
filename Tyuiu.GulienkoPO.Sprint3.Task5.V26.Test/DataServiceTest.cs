using Tyuiu.GulienkoPO.Sprint3.Task5.V26.Lib;

namespace Tyuiu.GulienkoPO.Sprint3.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 2;
            int starValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 13;

            double res = ds.GetSumSumSeries(x , starValue1, stopValue1, startValue2, stopValue2);
            double wait = 16374.544;
            Assert.AreEqual(res, wait);
        }
    }
}