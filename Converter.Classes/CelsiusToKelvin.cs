using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Classes {
    public class CelsiusToKelvin {
        public double convert(string celsius) {
            double kelvin = Convert.ToDouble(celsius) + 273.15;
            return kelvin;
        }
    }
}
