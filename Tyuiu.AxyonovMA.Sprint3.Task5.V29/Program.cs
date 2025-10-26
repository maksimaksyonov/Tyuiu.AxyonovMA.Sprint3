using Tyuiu.AxyonovMA.Sprint3.Task5.V29.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new();
        int x = 2; int startValue1 = 1; int startValue2 = 1; int stopValue1 = 3; int stopValue2 = 10;

        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Вычислить значение функции при x = 2                                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Значение x = " + x);
        Console.WriteLine("Старт первой суммы: " + startValue1);
        Console.WriteLine("Конец первой суммы: " + stopValue1);
        Console.WriteLine("Старт второй суммы: " + startValue2);
        Console.WriteLine("Конец второй суммы: " + stopValue2);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
        Console.ReadLine();
    }
}