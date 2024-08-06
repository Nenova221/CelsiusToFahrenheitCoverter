using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CelsiusToFahrenheit
{
    public class Converter
    {
        public static float CelsiusToFahrenheit(float C)
        {
            float F = ((C * 9) / 5) + 32;

            return F;
        }
    }
}
