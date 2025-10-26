using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint3.Task0.V16.Lib;

namespace Tyuiu.AxyonovMA.Sprint3.Task0.V16.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestGetMultiplySeries()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue = 1;
            int stopValue = 6;

            double expected = 1;
            for (int k = startValue; k <= stopValue; k++)
            {
                expected *= Math.Pow((double)x / k, 3);
            }

            expected = Math.Round(expected, 3, MidpointRounding.AwayFromZero);
            double actual = ds.GetMultiplySeries(x, startValue, stopValue);

            Assert.AreEqual(expected, actual);
        }
    }
}
