namespace Converter.WinForms {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextfield = new System.Windows.Forms.TextBox();
            this.inputUnit = new System.Windows.Forms.Label();
            this.resultNumber = new System.Windows.Forms.Label();
            this.resultUnit = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kelvinToCelsius = new System.Windows.Forms.RadioButton();
            this.celsiusToKelvin = new System.Windows.Forms.RadioButton();
            this.fahrenheitToCelsius = new System.Windows.Forms.RadioButton();
            this.celsiusToFahrenheit = new System.Windows.Forms.RadioButton();
            this.endTheProgram = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatur:";
            // 
            // inputTextfield
            // 
            this.inputTextfield.Location = new System.Drawing.Point(177, 50);
            this.inputTextfield.Name = "inputTextfield";
            this.inputTextfield.Size = new System.Drawing.Size(61, 31);
            this.inputTextfield.TabIndex = 1;
            // 
            // inputUnit
            // 
            this.inputUnit.AutoSize = true;
            this.inputUnit.Location = new System.Drawing.Point(244, 56);
            this.inputUnit.Name = "inputUnit";
            this.inputUnit.Size = new System.Drawing.Size(0, 25);
            this.inputUnit.TabIndex = 2;
            // 
            // resultNumber
            // 
            this.resultNumber.AutoSize = true;
            this.resultNumber.Location = new System.Drawing.Point(179, 84);
            this.resultNumber.Name = "resultNumber";
            this.resultNumber.Size = new System.Drawing.Size(0, 25);
            this.resultNumber.TabIndex = 3;
            // 
            // resultUnit
            // 
            this.resultUnit.AutoSize = true;
            this.resultUnit.Location = new System.Drawing.Point(246, 84);
            this.resultUnit.Name = "resultUnit";
            this.resultUnit.Size = new System.Drawing.Size(0, 25);
            this.resultUnit.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kelvinToCelsius);
            this.groupBox1.Controls.Add(this.celsiusToKelvin);
            this.groupBox1.Controls.Add(this.fahrenheitToCelsius);
            this.groupBox1.Controls.Add(this.celsiusToFahrenheit);
            this.groupBox1.Location = new System.Drawing.Point(36, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 179);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Umrechnung";
            // 
            // kelvinToCelsius
            // 
            this.kelvinToCelsius.AutoSize = true;
            this.kelvinToCelsius.Location = new System.Drawing.Point(6, 135);
            this.kelvinToCelsius.Name = "kelvinToCelsius";
            this.kelvinToCelsius.Size = new System.Drawing.Size(198, 29);
            this.kelvinToCelsius.TabIndex = 3;
            this.kelvinToCelsius.Text = "°Kelvin nach °Celsius";
            this.kelvinToCelsius.UseVisualStyleBackColor = true;
            this.kelvinToCelsius.CheckedChanged += new System.EventHandler(this.kelvinToCelsius_CheckedChanged);
            // 
            // celsiusToKelvin
            // 
            this.celsiusToKelvin.AutoSize = true;
            this.celsiusToKelvin.Location = new System.Drawing.Point(6, 100);
            this.celsiusToKelvin.Name = "celsiusToKelvin";
            this.celsiusToKelvin.Size = new System.Drawing.Size(198, 29);
            this.celsiusToKelvin.TabIndex = 2;
            this.celsiusToKelvin.Text = "°Celsius nach °Kelvin";
            this.celsiusToKelvin.UseVisualStyleBackColor = true;
            this.celsiusToKelvin.CheckedChanged += new System.EventHandler(this.celsiusToKelvin_CheckedChanged);
            // 
            // fahrenheitToCelsius
            // 
            this.fahrenheitToCelsius.AutoSize = true;
            this.fahrenheitToCelsius.Location = new System.Drawing.Point(6, 65);
            this.fahrenheitToCelsius.Name = "fahrenheitToCelsius";
            this.fahrenheitToCelsius.Size = new System.Drawing.Size(233, 29);
            this.fahrenheitToCelsius.TabIndex = 1;
            this.fahrenheitToCelsius.Text = "°Fahrenheit nach °Celsius";
            this.fahrenheitToCelsius.UseVisualStyleBackColor = true;
            this.fahrenheitToCelsius.CheckedChanged += new System.EventHandler(this.fahrenheitToCelsius_CheckedChanged);
            // 
            // celsiusToFahrenheit
            // 
            this.celsiusToFahrenheit.AutoSize = true;
            this.celsiusToFahrenheit.Location = new System.Drawing.Point(6, 30);
            this.celsiusToFahrenheit.Name = "celsiusToFahrenheit";
            this.celsiusToFahrenheit.Size = new System.Drawing.Size(233, 29);
            this.celsiusToFahrenheit.TabIndex = 0;
            this.celsiusToFahrenheit.Text = "°Celsius nach °Fahrenheit";
            this.celsiusToFahrenheit.UseVisualStyleBackColor = true;
            this.celsiusToFahrenheit.CheckedChanged += new System.EventHandler(this.celsiusToFahrenheit_CheckedChanged_1);
            // 
            // endTheProgram
            // 
            this.endTheProgram.Location = new System.Drawing.Point(36, 350);
            this.endTheProgram.Name = "endTheProgram";
            this.endTheProgram.Size = new System.Drawing.Size(257, 35);
            this.endTheProgram.TabIndex = 6;
            this.endTheProgram.Text = "Beenden";
            this.endTheProgram.UseVisualStyleBackColor = true;
            this.endTheProgram.Click += new System.EventHandler(this.endTheProgram_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(36, 9);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 25);
            this.error.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.error);
            this.Controls.Add(this.endTheProgram);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultUnit);
            this.Controls.Add(this.resultNumber);
            this.Controls.Add(this.inputUnit);
            this.Controls.Add(this.inputTextfield);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox inputTextfield;
        private Label inputUnit;
        private Label resultNumber;
        private Label resultUnit;
        private GroupBox groupBox1;
        private RadioButton kelvinToCelsius;
        private RadioButton celsiusToKelvin;
        private RadioButton fahrenheitToCelsius;
        private RadioButton celsiusToFahrenheit;
        private Button endTheProgram;
        private Label error;
    }
}