namespace Converter.WinForms {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void endTheProgram_Click(object sender, EventArgs e) {
            // end the program
            Application.Exit();
        }

        private void celsiusToFahrenheit_CheckedChanged_1(object sender, EventArgs e) {
            if(Convert.ToDouble(inputTextfield.Text) >= -273.15) {
                // convert celsius to fahrenheit
                double celsius = Convert.ToDouble(inputTextfield.Text);
                double fahrenheit = celsius * 1.8 + 32;
                resultNumber.Text = Math.Round(fahrenheit, 3).ToString();
                inputUnit.Text = "°C";
                resultUnit.Text = "°F";
            } else {
                // show error message
                error.Text = "Temperature below absolute zero!";
            }
        }

        private void fahrenheitToCelsius_CheckedChanged(object sender, EventArgs e) {
            if(Convert.ToDouble(inputTextfield.Text) >= -459.67) {
                // convert fahrenheit to celsius
                double fahrenheit = Convert.ToDouble(inputTextfield.Text);
                double celsius = (fahrenheit - 32) / 1.8;
                resultNumber.Text = Math.Round(celsius, 3).ToString();
                inputUnit.Text = "°F";
                resultUnit.Text = "°C";
            } else {
                // show error message
                error.Text = "Temperature below absolute zero!";
            }
        }

        private void celsiusToKelvin_CheckedChanged(object sender, EventArgs e) {
            if(Convert.ToDouble(inputTextfield.Text) >= -273.15) {
                // convert celsius to kelvin
                double celsius = Convert.ToDouble(inputTextfield.Text);
                double kelvin = celsius + 273.15;
                resultNumber.Text = Math.Round(kelvin, 3).ToString();
                inputUnit.Text = "°C";
                resultUnit.Text = "K";
            } else {
                // show error message
                error.Text = "Temperature below absolute zero!";
            }
        }

        private void kelvinToCelsius_CheckedChanged(object sender, EventArgs e) {
            if(Convert.ToDouble(inputTextfield.Text) >= 0) {
                // convert kelvin to celsius
                double kelvin = Convert.ToDouble(inputTextfield.Text);
                double celsius = kelvin - 273.15;
                resultNumber.Text = Math.Round(celsius, 3).ToString();
                inputUnit.Text = "K";
                resultUnit.Text = "°C";
            } else {
                // show error message
                error.Text = "Temperature below absolute zero!";
            }
        }
    }
}