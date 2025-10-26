using Tyuiu.AxyonovMA.Sprint3.Task5.V29.Lib;

namespace Tyuiu.AxyonovMA.Sprint3.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int x = 10;
            int startValue1 = 3;
            int stopValue1 = 3;
            int startValue2 = 10;
            int stopValue2 = 10;
            double wait = 0.456;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Assert.AreEqual(wait, res);
        }
    }
}