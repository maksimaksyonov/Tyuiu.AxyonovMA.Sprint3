using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AxyonovMA.Sprint3.Task5.V29.Lib
{
    public class DataService : ISprint3Task5V29
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            for (double i = startValue1; i <= stopValue1; i++)
            {
                for (double k = startValue2; k <= stopValue2; k++)
                {
                    double y = x / k + Math.Sin(x); res += y;
                }
            }
            return Math.Round(res, 3);
        }
    }
}