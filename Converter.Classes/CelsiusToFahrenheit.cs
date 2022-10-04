namespace Converter.Classes {
    public class CelsiusToFahrenheit {
        // function to convert celsius to fahrenheit
        public double convert(string celsius) {
            double fahrenheit = Convert.ToDouble(celsius) * 1.8 + 32;
            return fahrenheit;
        }
    }
}