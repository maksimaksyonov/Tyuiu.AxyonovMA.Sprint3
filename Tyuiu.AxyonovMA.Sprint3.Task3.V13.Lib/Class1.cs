using System;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AxyonovMA.Sprint3.Task3.V13.Lib
{
    public class DataService : ISprint3Task3V13
    {

        public int ConvertStringToInt(string value)
        {
            string result = "";
            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    result += c;
                }
            }
            return Int32.Parse(result);
        }
    }
}