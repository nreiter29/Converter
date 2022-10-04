using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Classes {
    public class KelvinToCelsius {
        public double convert(string input) {
            double kelvin = Convert.ToDouble(input);
            double celsius = kelvin - 273.15;
            return celsius;
        }
    }
}
