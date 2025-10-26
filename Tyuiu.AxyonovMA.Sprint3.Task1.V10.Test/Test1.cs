using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint3.Task1.V10.Lib;

namespace Tyuiu.AxyonovMA.Sprint3.Task1.V10.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void CalculateSum_ReturnsCorrectResult()
        {
            DataService ds = new DataService();
            double x = 5;

            double expected = 0;
            int i = 1;
            while (i <= 17)
            {
                expected += 1.0 / (i + Math.Pow(x, i));
                i++;
            }
            expected = Math.Round(expected, 6);

            double actual = ds.CalculateSum(x);
            Assert.AreEqual(expected, actual);
        }
    }
}
