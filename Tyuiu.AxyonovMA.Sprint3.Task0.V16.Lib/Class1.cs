using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AxyonovMA.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;

            for (int k = startValue; k <= stopValue; k++)
            {
                p *= Math.Pow((double)value / k, 3);
            }

            return Math.Round(p, 6);
        }
    }
}
