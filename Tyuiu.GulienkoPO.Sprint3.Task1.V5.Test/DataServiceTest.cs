using Tyuiu.GulienkoPO.Sprint3.Task1.V5.Lib;

namespace Tyuiu.GulienkoPO.Sprint3.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int endValue = 10;

            double res = ds.GetMultiplySeries(startValue, endValue);

            double wait = 3.179;

            Assert.AreEqual(wait, res);

        }
    }
}