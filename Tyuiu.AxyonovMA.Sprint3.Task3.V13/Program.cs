using System;
using Tyuiu.AxyonovMA.Sprint3.Task3.V13.Lib;

    class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string value = "?sd!! 5gh.s!";
        int result = 5;

        Console.WriteLine($" Искомая строка: {value}");
        Console.WriteLine($" Искомая буква, которую нужно удалить: {result}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($" Строка в итоге: {ds.ConvertStringToInt(value)}");
        Console.ReadKey();
    }
}