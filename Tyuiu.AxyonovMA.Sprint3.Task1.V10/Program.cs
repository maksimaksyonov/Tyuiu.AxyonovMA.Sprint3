using Tyuiu.AxyonovMA.Sprint3.Task1.V10.Lib;

Console.Title = "Спринт #3 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3 | Оператор цикла while | Задание #1 | Вариант #10             *");
Console.WriteLine("***************************************************************************");

int x = 5, startValue = 1, stopValue = 17;

var ds = new DataService();
double s = ds.GetSumSeries(x, startValue, stopValue);

Console.WriteLine($"S = {s:F3}");
Console.ReadKey();
