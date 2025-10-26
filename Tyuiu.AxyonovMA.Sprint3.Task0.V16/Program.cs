using Tyuiu.AxyonovMA.Sprint3.Task0.V16.Lib;

Console.Title = "Спринт #3 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Использование цикла for                                           *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("* Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет произведение ряда по формуле:     *");
Console.WriteLine("*                 6                                                       *");
Console.WriteLine("*       p = Π (x / k)^3, при x = 5                                        *");
Console.WriteLine("*                k=1                                                      *");
Console.WriteLine("***************************************************************************");

double x = 5;
DataService ds = new DataService();
double result = ds.CalculateProduct(x);

Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine($"x = {x}");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine($"p = {result:F3}");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Нажмите любую клавишу для выхода...");
Console.ReadKey();
