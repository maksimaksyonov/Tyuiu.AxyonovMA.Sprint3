using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint3.Task2.V24.Lib;

namespace Tyuiu.AxyonovMA.Sprint3.Task2.V24.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestGetMultiplySeries()
        {
            DataService ds = new DataService();
            double a = 0.25;
            int start = 1;
            int stop = 8;

            double expected = 1;
            int k = start;
            do
            {
                expected *= (Math.Pow(a, k) + 4) * Math.Cos(a);
                k++;
            }
            while (k <= stop);

            expected = Math.Round(expected, 3, MidpointRounding.AwayFromZero);
            double actual = ds.GetMultiplySeries(a, start, stop);

            Assert.AreEqual(expected, actual);
        }
    }
}
