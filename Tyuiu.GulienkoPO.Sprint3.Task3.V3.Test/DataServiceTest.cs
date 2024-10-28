using Tyuiu.GulienkoPO.Sprint3.Task3.V3.Lib;

namespace Tyuiu.GulienkoPO.Sprint3.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMinCharCount()
        {
            DataService ds = new DataService();

            string str = "cvbmzff orffgtrr dkfvfffdr";
            char chr = 'f';

            double res = ds.GetMinCharCount(str, chr);

            int wait = 8;

            Assert.AreEqual(wait, res);
        }
    }
}