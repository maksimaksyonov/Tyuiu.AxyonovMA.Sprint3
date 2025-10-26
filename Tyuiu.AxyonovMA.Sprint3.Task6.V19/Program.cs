using Tyuiu.AxyonovMA.Sprint3.Task6.V19.Lib;

namespace Tyuiu.AxyonovMA.Sprint3.Task6.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Напишите программу, которая ищет среди целых чисел,            *");
            Console.WriteLine("* принадлежащих числовому отрезку [10, 15] сумму всех делителей меньше 8  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 10;
            int stopValue = 15;
            Console.WriteLine(" Начало отрезка = " + startValue);
            Console.WriteLine(" Конец отрезка = " + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Сумма всех делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
