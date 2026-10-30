using Newtonsoft.Json.Linq;
using Tyuiu.GoreykoDV.Sprint3.Task1.V14.Lib;

namespace Tyuiu.GoreykoDV.Sprint3.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 0.7;
            int startValue = 1;
            int stopValue = 14;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 3.546;

            Assert.AreEqual(wait, res);
        }
    }
}
