using Converter.Classes;

namespace Converter.WinForms {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void endTheProgram_Click(object sender, EventArgs e) {
            // end the program
            Application.Exit();
        }

        public void clear() {
            error.Text = "";
            resultNumber.Text = "";
            resultUnit.Text = "";
        }

        private void celsiusToFahrenheit_CheckedChanged_1(object sender, EventArgs e) {
            if(Convert.ToDouble(inputTextfield.Text) >= -273.15) {
                clear();
                // convert celsius to fahrenheit
                CelsiusToFahrenheit calculate = new();
                double fahrenheit = calculate.convert(inputTextfield.Text);
                resultNumber.Text = Math.Round(fahrenheit, 3).ToString();
                inputUnit.Text = "°C";
                resultUnit.Text = "°F";
            } else {
                clear();
                // show error message
                error.Text = "Celsius is below absolute zero!";
            }
        }

        private void fahrenheitToCelsius_CheckedChanged(object sender, EventArgs e) {
            if(Convert.ToDouble(inputTextfield.Text) >= -459.67) {
                clear();
                // convert fahrenheit to celsius
                FahrenheitToCelsius calculate = new();
                double celsius = calculate.convert(inputTextfield.Text);
                resultNumber.Text = Math.Round(celsius, 3).ToString();
                inputUnit.Text = "°F";
                resultUnit.Text = "°C";
            } else {
                clear();
                // show error message
                error.Text = "Fahrenheit is below absolute zero!";
            }
        }

        private void celsiusToKelvin_CheckedChanged(object sender, EventArgs e) {
            if(Convert.ToDouble(inputTextfield.Text) >= -273.15) {
                clear();
                // convert celsius to kelvin
                CelsiusToKelvin calculate = new();
                double kelvin = calculate.convert(inputTextfield.Text);
                resultNumber.Text = Math.Round(kelvin, 3).ToString();
                inputUnit.Text = "°C";
                resultUnit.Text = "K";
            } else {
                clear();
                // show error message
                error.Text = "Celsius is below absolute zero!";
            }
        }

        private void kelvinToCelsius_CheckedChanged(object sender, EventArgs e) {
            if(Convert.ToDouble(inputTextfield.Text) >= 0) {
                clear();
                // convert kelvin to celsius
                KelvinToCelsius calculate = new();
                double celsius = calculate.convert(inputTextfield.Text);
                resultNumber.Text = Math.Round(celsius, 3).ToString();
                inputUnit.Text = "K";
                resultUnit.Text = "°C";
            } else {
                clear();
                // show error message
                error.Text = "Kelvin is below absolute zero!";
            }
        }
    }
}