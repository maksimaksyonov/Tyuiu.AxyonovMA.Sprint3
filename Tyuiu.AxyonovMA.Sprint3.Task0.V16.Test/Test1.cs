using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint3.Task0.V16.Lib;

namespace Tyuiu.AxyonovMA.Sprint3.Task0.V16.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void CalculateProduct_ReturnsCorrectResult()
        {
            DataService ds = new DataService();
            double x = 5;

            double expected = Math.Round(Math.Pow(5.0 / 1, 3) *
                                         Math.Pow(5.0 / 2, 3) *
                                         Math.Pow(5.0 / 3, 3) *
                                         Math.Pow(5.0 / 4, 3) *
                                         Math.Pow(5.0 / 5, 3) *
                                         Math.Pow(5.0 / 6, 3), 3);

            double actual = ds.CalculateProduct(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
