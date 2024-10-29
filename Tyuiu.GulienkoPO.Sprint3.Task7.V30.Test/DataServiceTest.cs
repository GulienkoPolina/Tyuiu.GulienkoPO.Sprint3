using Tyuiu.GulienkoPO.Sprint3.Task7.V30.Lib;

namespace Tyuiu.GulienkoPO.Sprint3.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -19.76;
            valueWaitArray[1] = -15.06;
            valueWaitArray[2] = -10.41;
            valueWaitArray[3] = -3.81;
            valueWaitArray[4] = -1.26;
            valueWaitArray[5] = 0.00;
            valueWaitArray[6] = 7.71;
            valueWaitArray[7] = 12.14;
            valueWaitArray[8] = 16.52;
            valueWaitArray[9] = 20.87;
            valueWaitArray[10] = 25.17;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}