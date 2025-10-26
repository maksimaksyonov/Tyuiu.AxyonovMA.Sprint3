using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint3.Task3.V13.Lib;

namespace Tyuiu.AxyonovMA.Sprint3.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetDigitSum()
        {
            DataService ds = new DataService();

            string value = "?sdl! Sgh. s!";
            int result = ds.GetDigitSum(value);

            // В строке "?sdl! Sgh. s!" нет цифр, поэтому ожидаем 0
            int expected = 0;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidGetDigitSumWithDigits()
        {
            DataService ds = new DataService();

            string value = "abc123def456!";
            int result = ds.GetDigitSum(value);

            // В строке "abc123def456!" цифры "123456", преобразуем в число 123456
            int expected = 123456;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidGetDigitSumEmptyResult()
        {
            DataService ds = new DataService();

            string value = "Hello World!";
            int result = ds.GetDigitSum(value);

            // В строке нет цифр, ожидаем 0
            int expected = 0;

            Assert.AreEqual(expected, result);
        }
    }
}