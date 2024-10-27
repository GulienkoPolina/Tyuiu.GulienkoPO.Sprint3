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
            int stopValue = 10;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 3.195;
            Assert.AreEqual(wait, res);




        }
    }
}