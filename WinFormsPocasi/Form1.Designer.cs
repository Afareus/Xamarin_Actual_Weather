
namespace WinFormsPocasi {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.lblCity = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblWeather = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCity.Location = new System.Drawing.Point(135, 74);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(58, 32);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(46, 167);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(82, 17);
            this.lblTemperature.TabIndex = 1;
            this.lblTemperature.Text = "Temperature";
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Location = new System.Drawing.Point(46, 220);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(56, 17);
            this.lblWeather.TabIndex = 2;
            this.lblWeather.Text = "Weather";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Location = new System.Drawing.Point(46, 271);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(38, 17);
            this.lblWind.TabIndex = 3;
            this.lblWind.Text = "Wind";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(46, 324);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(59, 17);
            this.lblHumidity.TabIndex = 4;
            this.lblHumidity.Text = "Humidity";
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Items.AddRange(new object[] {
            "Ostrava",
            "Bruntal",
            "Helsinky",
            "Stockholm",
            "Ottawa",
            "Athens",
            "London",
            "Bern"});
            this.comboBoxCities.Location = new System.Drawing.Point(73, 396);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(162, 25);
            this.comboBoxCities.TabIndex = 5;
            this.comboBoxCities.SelectedIndexChanged += new System.EventHandler(this.comboBoxCities_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 505);
            this.Controls.Add(this.comboBoxCities);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblCity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.ComboBox comboBoxCities;
    }
}

