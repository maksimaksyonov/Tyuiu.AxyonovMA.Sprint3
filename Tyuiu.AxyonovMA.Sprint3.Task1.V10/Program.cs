using Tyuiu.AxyonovMA.Sprint3.Task1.V10.Lib;

Console.Title = "Спринт #3 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла while                                              *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Вычислить сумму ряда:                                                   *");
Console.WriteLine("*        17                                                               *");
Console.WriteLine("*  S = Σ (1 / (i + x^i)), при x = 5                                       *");
Console.WriteLine("*       i=1                                                               *");
Console.WriteLine("***************************************************************************");

int x = 5;
int startValue = 1;
int stopValue = 17;

DataService ds = new DataService();
double result = ds.GetSumSeries(x, startValue, stopValue);

Console.WriteLine($"Результат: S = {result:F3}");
Console.ReadKey();
