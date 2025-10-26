using Tyuiu.AxyonovMA.Sprint3.Task2.V24.Lib;

Console.Title = "Спринт #3 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла do...while                                         *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #24                                                             *");
Console.WriteLine("* Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Используя цикл do...while, вычислить произведение ряда:                 *");
Console.WriteLine("*        8                                                                *");
Console.WriteLine("*  p = ∏ (a^k + 4) * cos(a), при a = 0.25                                *");
Console.WriteLine("*       k=1                                                               *");
Console.WriteLine("***************************************************************************");

double a = 0.25;
int startValue = 1;
int stopValue = 8;

DataService ds = new DataService();
double result = ds.GetMultiplySeries(a, startValue, stopValue);

Console.WriteLine($"Результат: p = {result:F3}");
Console.ReadKey();
