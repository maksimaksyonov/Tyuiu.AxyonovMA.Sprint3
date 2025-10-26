using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AxyonovMA.Sprint3.Task1.V10.Lib
{
    public class DataService : ISprint3Task1V10
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double s = 0;
            int i = startValue;
            while (i <= stopValue)
            {
                double term = 1.0 / (i + Math.Pow(value, i));
                s += Math.Pow(term, i);   // ВОЗВОДИМ В СТЕПЕНЬ i
                i++;
            }
            return Math.Round(s, 3, MidpointRounding.AwayFromZero);
        }
    }
}
