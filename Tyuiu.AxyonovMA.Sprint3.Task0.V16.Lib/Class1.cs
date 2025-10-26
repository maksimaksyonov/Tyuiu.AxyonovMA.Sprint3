using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AxyonovMA.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double CalculateProduct(double x)
        {
            double p = 1;

            for (int k = 1; k <= 6; k++)
            {
                p *= Math.Pow(x / k, 3);
            }

            return Math.Round(p, 3);
        }

        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}