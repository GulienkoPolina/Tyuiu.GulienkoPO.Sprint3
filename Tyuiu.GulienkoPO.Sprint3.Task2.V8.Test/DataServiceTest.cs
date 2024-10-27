using Tyuiu.GulienkoPO.Sprint3.Task2.V8.Lib;

namespace Tyuiu.GulienkoPO.Sprint3.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double wait = 0.001;

            Assert.AreEqual(res, wait);
        }
    }
}