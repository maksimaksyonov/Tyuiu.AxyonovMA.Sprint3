using System.Diagnostics.SymbolStore;
using tyuiu.cources.programming.interfaces.Sprint3;
using System;

namespace Tyuiu.AxyonovMA.Sprint3.Task7.V27.Lib
{
    public class DataService : ISprint3Task7V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Проверяем диаппппппазаон озон-зон-зон
            if (startValue > stopValue)
            {
                throw new ArgumentException("Начальное значение не может быть больше конечного");
            }

            // Вычисляем размер массиввного огромного нахуй льва
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == -1)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    // F(x) = cos(x)/(x+1) - cos(x)*1.3 + 3x 
                    double cosX = Math.Cos(x);
                    double numerator = cosX;                    //cos(x)
                    double denominator = x + 1;                //(x+1)
                    double firstTerm = numerator / denominator; //cos(x)/(x+1)
                    double secondTerm = cosX * 1.3;            //cos(x)*1.3
                    double thirdTerm = 3 * x;                  //3x

                    double result = firstTerm - secondTerm + thirdTerm;
                    //2 знака ,
                    valueArray[count] = Math.Round(result, 2);
                }

                count++;
            }

            return valueArray;
        }
    }
}