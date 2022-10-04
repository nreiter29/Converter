using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Classes {
    public class FahrenheitToCelsius {
        public double convert(string fahrenheit) {
            double celsius = (Convert.ToDouble(fahrenheit) - 32) / 1.8;
            return celsius;
        }
    }
}
