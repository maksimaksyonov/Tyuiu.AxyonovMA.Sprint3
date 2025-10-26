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
Console.WriteLine("* Используя цикл for, вычислить произведение ряда по формуле:             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("*          6                                                              *");
Console.WriteLine("*     p = ∏ ((x / k)^3), при x = 5                                        *");
Console.WriteLine("*         k=1                                                             *");
Console.WriteLine("***************************************************************************");

int x = 5;
int startValue = 1;
int stopValue = 6;

DataService ds = new DataService();
double result = ds.GetMultiplySeries(x, startValue, stopValue);

Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine($"x = {x}");
Console.WriteLine($"Начальное значение = {startValue}");
Console.WriteLine($"Конечное значение = {stopValue}");
Console.WriteLine("***************************************************************************");
Console.WriteLine($"Результат: p = {result:F6}");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Нажмите любую клавишу для выхода...");
Console.ReadKey();
