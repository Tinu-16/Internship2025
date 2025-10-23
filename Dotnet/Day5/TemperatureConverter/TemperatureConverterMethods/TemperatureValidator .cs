using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverterMethods
{
    internal class TemperatureValidator
    {
        public static bool IsValidator(double temperature)
        {
            if (temperature >= -273.15 && temperature <= 5500) 
                return true;
            else 
                return false;

        }
    }
}
