using Tyuiu.AxyonovMA.Sprint3.Task7.V27.Lib;

namespace Tyuiu.AxyonovMA.Sprint3.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            // Arrange (Подготовка полового воспитания огромного нахуй льва)
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            //
            // ебеним
            double[] expected = {
                14.91,  //x = -5
                9.85,   //x = -4
                6.15,   //x = -3
                3.21,   //x = -2
                0,      //x = -1 (/0
                -2.70,  //x = 0
                -4.57,  //x = 1
                -5.31,  //x = 2
                -4.60,  //x = 3
                -2.19,  //x = 4
                1.94    //x = 5
            };

            // Act половой (Действие)
            double[] result = ds.GetMassFunction(startValue, stopValue);

            // Assert (Проверка)
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidCheckDivisionByZero()
        {
            // арнаж
            DataService ds = new DataService();
            int startValue = -2;
            int stopValue = 0;

            // первый половой акт
            double[] result = ds.GetMassFunction(startValue, stopValue);

            // Assert - проверяем, что при бимбимибим при x = -1 возвращается 0
            Assert.AreEqual(0, result[1]); // 1
        }

        [TestMethod]
        public void ValidArrayLength()
        {
            // Аранж
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            // Ожидаемая нахуй огромная длина массива: от -5до5 включительно
            int expectedLength = 11;

            // Половой акт
            double[] result = ds.GetMassFunction(startValue, stopValue);

            // Ассеrт
            Assert.AreEqual(expectedLength, result.Length);
        }
    }
}