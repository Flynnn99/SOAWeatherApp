namespace WeatherApp
{
    partial class Weather
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CitiesListBox = new ListBox();
            DisplayWeather = new Button();
            DisplayWeatherLabel = new Label();
            SuspendLayout();
            // 
            // CitiesListBox
            // 
            CitiesListBox.FormattingEnabled = true;
            CitiesListBox.ItemHeight = 25;
            CitiesListBox.Location = new Point(22, 15);
            CitiesListBox.Name = "CitiesListBox";
            CitiesListBox.Size = new Size(391, 454);
            CitiesListBox.TabIndex = 0;
            CitiesListBox.SelectedIndexChanged += CitiesListBox_SelectedIndexChanged;
            // 
            // DisplayWeather
            // 
            DisplayWeather.Location = new Point(431, 432);
            DisplayWeather.Name = "DisplayWeather";
            DisplayWeather.Size = new Size(175, 37);
            DisplayWeather.TabIndex = 1;
            DisplayWeather.Text = "Display Weather";
            DisplayWeather.UseVisualStyleBackColor = true;
            DisplayWeather.Click += button1_Click_1;
            // 
            // DisplayWeatherLabel
            // 
            DisplayWeatherLabel.Location = new Point(431, 31);
            DisplayWeatherLabel.Name = "DisplayWeatherLabel";
            DisplayWeatherLabel.Size = new Size(380, 377);
            DisplayWeatherLabel.TabIndex = 2;
            DisplayWeatherLabel.Text = "Display Cities";
            DisplayWeatherLabel.Click += label1_Click;
            // 
            // Weather
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 574);
            Controls.Add(DisplayWeatherLabel);
            Controls.Add(DisplayWeather);
            Controls.Add(CitiesListBox);
            Name = "Weather";
            Text = "Form1";
            Load += Weather_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox CitiesListBox;
        private Button DisplayWeather;
        private Label DisplayWeatherLabel;
    }
}