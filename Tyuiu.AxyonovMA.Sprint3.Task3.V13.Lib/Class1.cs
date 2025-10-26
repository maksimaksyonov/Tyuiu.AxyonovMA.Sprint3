using System;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AxyonovMA.Sprint3.Task3.V13.Lib
{
    public class DataService : ISprint3Task3V13
    {
        public int ConvertStringToInt(string value)
        {
            throw new NotImplementedException();
        }

        public int GetDigitSum(string value)
        {
            StringBuilder digitsOnly = new StringBuilder();

            foreach (char c in value)
            {
                
                if (char.IsDigit(c))
                {
                    digitsOnly.Append(c);
                }
            }

            
            if (digitsOnly.Length == 0)
            {
                return 0;
            }

            
            string resultString = digitsOnly.ToString();
            int result = int.Parse(resultString);

            return result;
        }
    }
}