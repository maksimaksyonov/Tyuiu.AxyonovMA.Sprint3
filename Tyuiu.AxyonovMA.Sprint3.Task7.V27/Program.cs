using Tyuiu.AxyonovMA.Sprint3.Task7.V27.Lib;

namespace Tyuiu.AxyonovMA.Sprint3.Task7.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Табулирование функции";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Задаем параметры табульбульблуьирования
            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"* Старт диапазона: {startValue}                                           *");
            Console.WriteLine($"* Конец диапазона: {stopValue}                                            *");
            Console.WriteLine($"* Шаг: 1                                                                 *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Создаем объект обожания спирина и получаем результаты
            DataService ds = new DataService();
            double[] valueArray = ds.GetMassFunction(startValue, stopValue);

            // огромная нахуй таблоица х и у
            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |    F(x)   |");
            Console.WriteLine("+----------+-----------+");

            // вывод рез
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,6:f2}   |", x, valueArray[count]);
                count++;
            }

            Console.WriteLine("+----------+-----------+");
            Console.ReadKey();
        }
    }
}