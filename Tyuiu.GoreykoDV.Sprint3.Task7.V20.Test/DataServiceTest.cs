using Newtonsoft.Json.Linq;
using Tyuiu.GoreykoDV.Sprint3.Task7.V20.Lib;

namespace Tyuiu.GoreykoDV.Sprint3.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue+1;

            double[] valueMaitArray;
            valueMaitArray = new double[len];

            valueMaitArray[0] = 17.27;
            valueMaitArray[1] = 14.08;
            valueMaitArray[2] = 10.27;
            valueMaitArray[3] = 6.65;
            valueMaitArray[4] = 3.87;
            valueMaitArray[5] = 2.00;
            valueMaitArray[6] = -0.74;
            valueMaitArray[7] = -3.71;
            valueMaitArray[8] = -7.59;
            valueMaitArray[9] = -11.55;
            valueMaitArray[10] = -14.74;

            double[] res;
            
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(valueMaitArray, res);
            
        }
    }
}
