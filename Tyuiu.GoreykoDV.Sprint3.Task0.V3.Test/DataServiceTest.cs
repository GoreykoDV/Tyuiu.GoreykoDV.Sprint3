using Tyuiu.GoreykoDV.Sprint3.Task0.V3.Lib;

namespace Tyuiu.GoreykoDV.Sprint3.Task0.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = 0.353;

            Assert.AreEqual(wait, res);
        }
    }
}
