using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint3.Task1.V10.Lib;

namespace Tyuiu.AxyonovMA.Sprint3.Task1.V10.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestGetSumSeries()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue = 1;
            int stopValue = 17;

            double expected = 0;
            int i = startValue;
            while (i <= stopValue)
            {
                expected += 1.0 / (i + Math.Pow(x, i));
                i++;
            }

            expected = Math.Round(expected, 3, MidpointRounding.AwayFromZero);
            double actual = ds.GetSumSeries(x, startValue, stopValue);

            Assert.AreEqual(expected, actual);
        }
    }
}
