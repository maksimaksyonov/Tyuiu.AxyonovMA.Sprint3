namespace Tyuiu.AxyonovMA.Sprint3.Task6.V19.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint3;

    public class DataService : ISprint3Task6V19
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                for (int d = 1; d < 8; d++)
                {
                    if (i % d == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}