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
Console.WriteLine("* S = Σ_{i=1..17} (1 / (i + x^i)), при x = 5 (цикл while)                 *");
Console.WriteLine("***************************************************************************");

double x = 5;
DataService ds = new DataService();
double result = ds.CalculateSum(x);

Console.WriteLine($"S = {result:F6}");
Console.ReadKey();
