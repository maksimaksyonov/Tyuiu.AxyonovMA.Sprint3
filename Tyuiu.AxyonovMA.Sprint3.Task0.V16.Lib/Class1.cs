namespace Tyuiu.AxyonovMA.Sprint3.Task0.V16.Lib
{
    public class DataService
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
    }
}