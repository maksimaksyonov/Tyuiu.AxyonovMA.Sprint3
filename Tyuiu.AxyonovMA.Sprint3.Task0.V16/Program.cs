using Tyuiu.AxyonovMA.Sprint3.Task0.V16.Lib;

Console.Title = "Спринт #3 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла for                                                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("* Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, используя цикл for, которая вычисляет произведение *");
Console.WriteLine("* ряда по формуле p = Π (x / k)^3 при x = 5, k = 1..6                    *");
Console.WriteLine("***************************************************************************");

int x = 5;
int startValue = 1;
int stopValue = 6;

DataService ds = new DataService();
double result = ds.GetMultiplySeries(x, startValue, stopValue);

Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine($"x = {x}");
Console.WriteLine($"Начальное значение k = {startValue}");
Console.WriteLine($"Конечное значение k = {stopValue}");
Console.WriteLine("***************************************************************************");
Console.WriteLine($"РЕЗУЛЬТАТ: p = {result:F3}");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Нажмите любую клавишу для выхода...");
Console.ReadKey();
