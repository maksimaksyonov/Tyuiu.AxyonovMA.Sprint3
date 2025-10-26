using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint3.Task1.V10.Lib;

namespace Tyuiu.AxyonovMA.Sprint3.Task1.V10.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void GetSumSeries_Correct()
        {
            var ds = new DataService();
            int x = 5, start = 1, stop = 17;

            double expected = 0;
            int i = start;
            while (i <= stop)
            {
                double term = 1.0 / (i + Math.Pow(x, i));
                expected += Math.Pow(term, i);
                i++;
            }
            expected = Math.Round(expected, 3, MidpointRounding.AwayFromZero);

            Assert.AreEqual(expected, ds.GetSumSeries(x, start, stop));
        }
    }
}
